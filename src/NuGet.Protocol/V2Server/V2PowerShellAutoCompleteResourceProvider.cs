﻿//using System.ComponentModel.Composition;
//using NuGet.Client.VisualStudio;
//using System.Collections.Concurrent;
//using System.Threading.Tasks;
//using System;
//using System.Threading;

//namespace NuGet.Protocol
//{
    
//    [NuGetResourceProviderMetadata(typeof(PSAutoCompleteResource), "V2PowerShellAutoCompleteResourceProvider", NuGetResourceProviderPositions.Last)]
//    public class V2PowerShellAutoCompleteResourceProvider : V2ResourceProvider
//    {
//        public override async Task<Tuple<bool, INuGetResource>> TryCreate(SourceRepository source, CancellationToken token)
//        {
//            V2PowerShellAutoCompleteResource resource = null;
//            var v2repo = await GetRepository(source, token);

//            if (v2repo != null)
//            {
//                resource = new V2PowerShellAutoCompleteResource(v2repo);
//            }

//            return new Tuple<bool, INuGetResource>(resource != null, resource);
//        }
//    }
//}
