﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentTaskSample
{
    internal class User
    {
        public User(string userId, string userName, string directoryProvider, string mention, string email)
        {
            UserId = userId;
            UserName = userName;
            DirectoryProvider = directoryProvider;
            Mention = mention;
            Email = email;
        }

        public string UserId { get; set; }

        public string UserName { get; set; }

        public string DirectoryProvider { get; set; }

        public string Mention { get; set; }

        public string Email { get; set; }
    }
}