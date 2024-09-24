﻿using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.Models;

namespace Services.UnitOfWork
{
    public class UnitOfWork
    {
        private AccountRepository _accountRepository;
        private ApplicationRepository _applicationRepository;
        private QuestionRepository _questionRepository;
        private JobRepository _jobRepository;
        private DBContext _dbContext;
        public UnitOfWork(DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public AccountRepository AccountRepo
        {
            get
            {
                if (_accountRepository == null)
                {
                    _accountRepository = new AccountRepository(_dbContext);
                }
                return _accountRepository;
            }
        }

        public ApplicationRepository ApplicationRepo
        {
            get
            {
                if(_applicationRepository == null)
                {
                    _applicationRepository = new ApplicationRepository(_dbContext);
                }
                return _applicationRepository;
            }
        }

        public QuestionRepository QuestionRepo
        {
            get
            {
                if(_questionRepository == null)
                {
                    _questionRepository = new QuestionRepository(_dbContext);
                }
                return _questionRepository;
            }
        }

        public JobRepository JobRepo
        {
            get
            {
                if(_jobRepository == null)
                {
                    _jobRepository = new JobRepository(_dbContext);
                }
                return _jobRepository;
            }
        }

    }
}