﻿using Nyan.Core.Modules.Identity;
using Nyan.Core.Modules.Cache;
using Nyan.Core.Modules.Encryption;
using Nyan.Core.Modules.Scope;
using Nyan.Core.Modules.Log;
using Nyan.Core.Settings;
using Nyan.Modules.Cache.Memory;
using System;

namespace Nyan.Modules.Data.PgSql
{
    [PackagePriority(Level = -2)]
    public class PgSqlSettingsPackage : IPackage
    {
        public PgSqlSettingsPackage()
        {
            Log = new NullLogProvider();
            Cache = new MemoryCacheProvider();
            Encryption = new NullEncryptionProvider();
            Scope = new DefaultScopeProvider();
            GlobalConnectionBundleType = typeof(PgSqlBundle);
        }

        public ICacheProvider Cache { get; set; }
        public IEncryptionProvider Encryption { get; set; }
        public IAuthorizationProvider Authorization { get; private set; }
        public IScopeProvider Scope { get; set; }
        public Type GlobalConnectionBundleType { get; set; }
        public LogProvider Log { get; set; }
    }
}
