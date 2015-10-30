﻿using System;
using Nyan.Core.Modules.Authorization;
using Nyan.Core.Modules.Cache;
using Nyan.Core.Modules.Encryption;
using Nyan.Core.Modules.Log;
using Nyan.Core.Modules.Scope;
using Nyan.Core.Settings;

namespace Nyan.Modules.Data.SQLCompact
{
    [PackagePriority(Level = -2)]
    // Data adapter package priority (higher than default (-3), but lower than pre-specified packages (-1)
    // ReSharper disable once InconsistentNaming
    public class SqlCompactSettingsPackage : IPackage
    {
        public SqlCompactSettingsPackage()
        {
            Log = new NullLogProvider();
            Cache = new NullCacheProvider();
            Encryption = new NullEncryptionProvider();
            Scope = new DefaultScopeProvider();
            GlobalConnectionBundleType = typeof (SqlCompactBundle);
        }

        public ICacheProvider Cache { get; set; }
        public IEncryptionProvider Encryption { get; set; }
        public IAuthorizationProvider Authorization { get; private set; }
        public IScopeProvider Scope { get; set; }
        public Type GlobalConnectionBundleType { get; set; }
        public LogProvider Log { get; set; }
    }
}