#region License

//
// Author: Ivan Porto Carrero <ivan@flanders.co.nz>
// Copyright � 2008, Flanders International Marketing Ltd.
// Copyright � 2007-2009, Enkari, Ltd.
// Copyright � 2009 Ian Davis <ian.f.davis@gmail.com>
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

#endregion

#region Using Directives

using Ninject.Extensions.Logging.NLog.Infrastructure;

#endregion

namespace Ninject.Extensions.Logging.NLog
{
    /// <summary>
    /// Extends the functionality of the kernel, providing integration between the Ninject
    /// logging infrastructure and nlog.
    /// </summary>
    public class NLogModule : LoggerModuleBase
    {
        /// <summary>
        /// Loads the module into the kernel.
        /// </summary>
        public override void Load()
        {
            Bind<ILoggerFactory>().ToConstant( new NLogLoggerFactory() );
            base.Load();
        }
    }
}