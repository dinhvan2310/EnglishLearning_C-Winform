﻿using BLL.Components;
using PBLLibrary;
using Library;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Workflows
{
    public class SettingWorkflow
    {
        public static SettingWorkflow Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new SettingWorkflow();


                return _Instance;
            }

            private set { }
        }
        private static SettingWorkflow _Instance;

        private SoundManager _SoundManager;

        private SettingWorkflow()
        {
            _SoundManager = new SoundManager();
        }


        public void Speak(string sentence)
        {
            _SoundManager.Speak(sentence);
        }


        public void ChangeVolumn(int volumn)
        {
            _SoundManager.ChangeVolumn(volumn);
        }

        public void ChangeVoice(Voice voice)
        {
            _SoundManager.ChangeVoice(voice);
        }

        public bool IsSpeaking()
        {
            return _SoundManager.IsSpeaking;
        }

        /// <summary>
        /// This function creates a JSON file containing default user settings for a given user ID.
        /// </summary>
        /// <param name="UserID">The ID of the user for whom the user settings JSON file is being created.
        /// </param>
        private void CreateStandardUserSettingsJson(int UserID)
        {
            string fileFullPath = GlobalConfig.Instance.PathFileJS() + "UserSettings.json";
            UserSetting userSetting = new UserSetting()
            {
                UserId = UserID,
                Volume = 10,
                Voice = false,
                Goal = 45,
            };
            List<UserSetting> userSettings = new List<UserSetting>();
            userSettings.Add(userSetting);
            string output = JsonConvert.SerializeObject(userSettings, Formatting.Indented);
            File.WriteAllText(fileFullPath, output);
        }

        /// <summary>
        /// This function applies user settings for volume and voice based on the user ID by reading from a JSON
        /// file.
        /// </summary>
        /// <param name="UserID">The ID of the user whose settings are being applied.</param>
        public void ApplyUserSettings(int UserID)
        {
            string fileFullPath = GlobalConfig.Instance.PathFileJS() + "UserSettings.json";
            string json = File.ReadAllText(fileFullPath);
            if (json == "")
            {
                CreateStandardUserSettingsJson(UserID);
                json = File.ReadAllText(fileFullPath);
            }
            JsonConvert.DeserializeObject<List<UserSetting>>(json).ForEach(item =>
            {
                if (item.UserId == UserID)
                {
                    ChangeVolumn(item.Volume * 10);
                    ChangeVoice(item.Voice == false ? Voice.Male : Voice.Female);
                }
            });
        }

        public UserSetting GetUserSettings(int UserID)
        {
            string fileFullPath = GlobalConfig.Instance.PathFileJS() + "UserSettings.json";
            string json = File.ReadAllText(fileFullPath);
            if (json == "")
            {
                CreateStandardUserSettingsJson(UserID);
                json = File.ReadAllText(fileFullPath);
            }
            List<UserSetting> userSettings = JsonConvert.DeserializeObject<List<UserSetting>>(json);
            UserSetting userSetting = userSettings.FirstOrDefault(p => p.UserId == UserID);
            if(userSetting == null)
            {
                UserSetting temp = new UserSetting()
                {
                    UserId = UserID,
                    Volume = 10,
                    Voice = false,
                    Goal = 45,
                };
                userSettings.Add(temp);
                string output = JsonConvert.SerializeObject(userSettings, Formatting.Indented);
                File.WriteAllText(fileFullPath, output);

                return temp;
            }
            else
            {
                return userSetting;
            }
        }

        /// <summary>
        /// The function sets a user's goal in a JSON file containing user settings.
        /// </summary>
        /// <param name="UserID">The ID of the user whose goal is being set.</param>
        /// <param name="Goal">The goal parameter is an integer value representing the user's desired goal. It
        /// is used in the SetUserGoal method to update or create a new user setting for the specified user
        /// ID.</param>
        public void SetUserGoal(int UserID, int Goal)
        {
            List<UserSetting> userSettings = new List<UserSetting>();
            string fileFullPath = GlobalConfig.Instance.PathFileJS() + "UserSettings.json";
            
            string json = File.ReadAllText(fileFullPath);
            if (json == "")
            {
                CreateStandardUserSettingsJson(UserID);
                json = File.ReadAllText(fileFullPath);
            }
            userSettings = JsonConvert.DeserializeObject<List<UserSetting>>(json);
            
            bool check = false;
            for (int i = 0; i < userSettings.Count; i++)
            {
                if (userSettings[i].UserId == UserID)
                {
                    userSettings[i].Goal = Goal;
                    check = true;
                    break;
                }
            }
            if (check == false)
            {
                userSettings.Add(new UserSetting()
                {
                    UserId = UserID,
                    Volume = 10,
                    Voice = false,
                    Goal = Goal,
                });
            }

            string output = JsonConvert.SerializeObject(userSettings, Formatting.Indented);
            File.WriteAllText(fileFullPath, output);
        }

        /// <summary>
        /// The function sets the user settings for a given user ID by updating or adding the volume and voice
        /// settings in a JSON file.
        /// </summary>
        /// <param name="UserID">An integer value representing the unique identifier of the user whose settings
        /// are being set or updated.</param>
        /// <param name="Volume">The volume parameter is an integer value that represents the volume level for a
        /// user's settings. It can range from 0 to 100, with 0 being muted and 100 being the maximum
        /// volume.</param>
        /// <param name="Voice">A boolean value indicating whether the user has enabled voice commands or not.
        /// </param>
        public void SetUserSettings(int UserID, int Volume, bool Voice)
        {
            List<UserSetting> userSettings = new List<UserSetting>();
            string fileFullPath = GlobalConfig.Instance.PathFileJS() + "UserSettings.json"; 
            string json = File.ReadAllText(fileFullPath);
            if (json == "")
            {
                CreateStandardUserSettingsJson(UserID);
                json = File.ReadAllText(fileFullPath);
            }
            userSettings = JsonConvert.DeserializeObject<List<UserSetting>>(json);
            bool check = false;
            for (int i = 0; i < userSettings.Count; i++)
            {
                if (userSettings[i].UserId == UserID)
                {
                    userSettings[i].Volume = Volume;
                    userSettings[i].Voice = Voice;
                    check = true;
                    break;
                }
            }
            if (check == false)
            {
                userSettings.Add(new UserSetting()
                {
                    UserId = UserID,
                    Volume = Volume,
                    Voice = Voice,
                });
            }
            string output = JsonConvert.SerializeObject(userSettings, Formatting.Indented);
            File.WriteAllText(fileFullPath, output);
        }


    }

    public class UserSetting 
    {
        public int UserId { set; get; }
        public int Volume { set; get; }
        public bool Voice { set; get; } // false: Male; true: Female
        public int Goal { set; get; }
    }

}

