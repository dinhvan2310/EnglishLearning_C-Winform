﻿using BLL.Workflows;
using EFramework.Model;
using EFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.TransferObjects;
using PBLLibrary;
using System.Data.Entity;

namespace BLL.Components
{
    public class NotebookManager
    {

        public bool CheckWordIsExistInNotebook(int userID, string word)
        {
            using (var db = new DictionaryContext())
            {
                var rs = db.Notebook.Where(p => p.AccountID == userID
                && p.Wn_Word.word.ToLower() == word.ToLower()).FirstOrDefault();
                if (rs == null)
                {
                    return false;
                }
                return true;

            }
        }

        public void AddWord(int userID, string word)
        {
            if (userID != -1)
            {
                using (var db = new DictionaryContext())
                {
                    var w = db.Wn_word
                        .Where(p => p.word.ToLower() == word.ToLower())
                        .Select(p => new { p.w_num, p.synset_id })
                        .FirstOrDefault();

                    Notebook notebook = new Notebook()
                    {
                        AccountID = userID,
                        WordNum = w.w_num,
                        SynsetID = w.synset_id,
                        LearnedPercent = 0
                    };
                    db.Notebook.Add(notebook);

                    db.SaveChanges();
                }
            }
        }

        public void RemoveWord(int userID, string word)
        {
            if (userID != -1)
            {
                using (var db = new DictionaryContext())
                {
                    var rs = db.Notebook
                        .Where(p => p.Wn_Word.word.Equals(word) && p.AccountID == userID)
                        .FirstOrDefault();
                    db.Notebook.Remove(rs);
                    db.SaveChanges();
                }
            }
        }

        public List<Notebook> GetNotebookWord_All(int userID)
        {
            using (var db = new DictionaryContext())
            {
                List<Notebook> result = db.Notebook
                    .Where(p => p.AccountID == userID)
                    .Include(p => p.Wn_Word)
                    .ToList();

                return result;
            }
        }

        public List<Notebook> GetSortedWord_ByPercentLearning(int userID, string order)
        {
            using (var db = new DictionaryContext())
            {
                List<Notebook> result = new List<Notebook>();

                if (order == "ascending")
                {
                    result = db.Notebook
                        .Where(w => w.AccountID == userID)
                        .OrderBy(w => w.LearnedPercent)
                        .Include(p => p.Wn_Word)
                        .ToList();

                }
                else
                {
                    result = db.Notebook
                        .Where(w => w.AccountID == userID)
                        .OrderByDescending(w => w.LearnedPercent)
                        .Include(p => p.Wn_Word)
                        .ToList();
                }

                return result;
            }

        }

        public void IncreaseLearnedPercent(int userID, string word, int num)
        {
            using (var db = new DictionaryContext())
            {
                var rs = db.Notebook
                    .Where(x => x.AccountID == userID && x.Wn_Word.word == word)
                    .FirstOrDefault();

                rs.LearnedPercent += num;
                db.SaveChanges();
            }
        }
        public List<Notebook> GetNotebookWord_Random(int userID, int limit)
        {
            using (var db = new DictionaryContext())
            {
                List<Notebook> result = db.Notebook
                    .Where(p => p.AccountID == userID)
                    .Include(p => p.Wn_Word)
                    .Shuffle(new Random())
                    .Take(limit)
                    .ToList();

                return result;
            }
        }
        public int GetNotebookCount(int userID)
        {
            using (var db = new DictionaryContext())
            {
                return db.Notebook
                    .Where(p => p.AccountID == userID)
                    .Count();
            }
        }
    }
}
