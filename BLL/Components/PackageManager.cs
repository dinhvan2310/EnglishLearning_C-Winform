﻿using EFramework;
using EFramework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Components
{
    public class PackageManager
    {
        public UserPacket GetPacket_ByName(string packetName)
        {
            using (DictionaryContext dbContext = new DictionaryContext())
            {
                UserPacket result = new UserPacket();


                result = dbContext.UserPacket
                        .Single(p => p.Name == packetName);

                return result;
            }
        }

        public bool SetPricePacket(string packetName, int price)
        {
            try
            {
                using (DictionaryContext dbContext = new DictionaryContext())
                {
                    UserPacket result = new UserPacket();
                    result = dbContext.UserPacket
                            .Single(p => p.Name == packetName);
                    result.Price = price;
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public UserPacketInfo GetUserPacketInfo(int userID, string namePacket)
        {
            using (var dbContext = new DictionaryContext())
            {
                if (dbContext.UserPacket.SingleOrDefault(p => p.Name == namePacket) == null)
                    return null;
                int packetID = dbContext.UserPacket.SingleOrDefault(p => p.Name == namePacket).PacketID;
                return dbContext.UserPacketInfo.SingleOrDefault(p => p.AccountID == userID && p.PacketID == packetID);
            }
        }

        public bool IsHasUserPacket(int userID, string namePacket)
        {
            return (GetUserPacketInfo(userID, namePacket) != null) ? true : false;
        }

        /// <summary>
        /// Trả về false nếu userPacket của người dùng đã hết hạn
        /// Trả về true trong mọi trường hợp còn lại
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="namePacket"></param>
        /// <returns></returns>
        public bool CheckUserPackageDuration(int userID, string namePacket)
        {
            using (var dbContext = new DictionaryContext())
            {
                UserPacket userPacket = dbContext.UserPacket.SingleOrDefault(p => p.Name == namePacket);
                if (userPacket == null)
                    return true;
                int packetID = userPacket.PacketID;
                UserPacketInfo userPacketInfo = dbContext.UserPacketInfo.SingleOrDefault(p => p.PacketID == packetID && p.AccountID == userID);
                if (userPacketInfo != null)
                {
                    if (userPacketInfo.DueDate < DateTime.Now)
                    {
                        CancelUserPacket(userID, namePacket);
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return true;
                }

            }
        }

        private bool CancelUserPacket(int userID, string namePacket)
        {
            using (var dbContext = new DictionaryContext())
            {
                UserPacket userPacket = dbContext.UserPacket.SingleOrDefault(p => p.Name == namePacket);
                if (userPacket == null)
                {
                    return false;
                }
                int packetID = userPacket.PacketID;
                UserPacketInfo userPacketInfo = dbContext.UserPacketInfo.SingleOrDefault(p => p.PacketID == packetID && p.AccountID == userID);
                if (userPacketInfo != null)
                {
                    dbContext.UserPacketInfo.Remove(userPacketInfo);
                    dbContext.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool BuyUserPacket(int userID, string namePacket)
        {
            using (var dbContext = new DictionaryContext())
            {
                AccountManager am = new AccountManager();
                int balance = am.GetAccountDetail(userID).Balance;
                UserPacket userPacket = dbContext.UserPacket.SingleOrDefault(p => p.Name == namePacket);
                if (userPacket == null)
                    return false;
                int pricePacket = userPacket.Price;
                int packetID = userPacket.PacketID;
                if (balance >= pricePacket)
                {
                    var detailedInformation = dbContext.DetailedInformation.Find(userID);
                    detailedInformation.Balance = balance - pricePacket;
                    /*dbContext.SaveChanges();*/
                    UserPacketInfo userPacketInfo = new UserPacketInfo()
                    {
                        AccountID = userID,
                        PacketID = packetID,
                        DueDate = DateTime.Now.AddDays(userPacket.TimeOfUse),
                    };
                    dbContext.UserPacketInfo.Add(userPacketInfo);
                    dbContext.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }

        public List<UserPacketInfo> GetUserPacketInfo_All_ByNamePacket(string namePacket)
        {
            using (var dbContext = new DictionaryContext())
            {
                if (dbContext.UserPacket.SingleOrDefault(p => p.Name == namePacket) == null)
                    return null;
                int packetID = dbContext.UserPacket.SingleOrDefault(p => p.Name == namePacket).PacketID;
                return dbContext.UserPacketInfo.Where(p => p.PacketID == packetID).ToList();
            }
        }

        public List<UserPacket> GetAllUserPackage()
        {
            using (var dbContext = new DictionaryContext())
            {
                return dbContext.UserPacket.ToList();
            }
        }
    }
}
