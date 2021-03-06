/**
* Copyright 2018 IBM Corp. All Rights Reserved.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*      http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/

using System.Collections.Generic;
using Newtonsoft.Json;

namespace IBM.WatsonDeveloperCloud.LanguageTranslator.v2.Model
{
    /// <summary>
    /// IdentifiableLanguages.
    /// </summary>
    public class IdentifiableLanguages
    {
        /// <summary>
        /// A list of all languages that the service can identify.
        /// </summary>
        /// <value>A list of all languages that the service can identify.</value>
        [JsonProperty("languages", NullValueHandling = NullValueHandling.Ignore)]
        public List<IdentifiableLanguage> Languages { get; set; }
    }

}
