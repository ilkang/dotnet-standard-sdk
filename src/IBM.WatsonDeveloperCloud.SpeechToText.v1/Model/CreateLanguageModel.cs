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

using Newtonsoft.Json;

namespace IBM.WatsonDeveloperCloud.SpeechToText.v1.Model
{
    /// <summary>
    /// CreateLanguageModel.
    /// </summary>
    public class CreateLanguageModel
    {
        /// <summary>
        /// A user-defined name for the new custom language model. Use a name that is unique among all custom language models that you own. Use a localized name that matches the language of the custom model. Use a name that describes the domain of the custom model, such as `Medical custom model` or `Legal custom model`.
        /// </summary>
        /// <value>A user-defined name for the new custom language model. Use a name that is unique among all custom language models that you own. Use a localized name that matches the language of the custom model. Use a name that describes the domain of the custom model, such as `Medical custom model` or `Legal custom model`.</value>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
        /// <summary>
        /// The name of the base language model that is to be customized by the new custom language model. The new custom model can be used only with the base model that it customizes. To determine whether a base model supports language model customization, request information about the base model and check that the attribute `custom_language_model` is set to `true`, or refer to [Language support for customization](https://console.bluemix.net/docs/services/speech-to-text/custom.html#languageSupport).
        /// </summary>
        /// <value>The name of the base language model that is to be customized by the new custom language model. The new custom model can be used only with the base model that it customizes. To determine whether a base model supports language model customization, request information about the base model and check that the attribute `custom_language_model` is set to `true`, or refer to [Language support for customization](https://console.bluemix.net/docs/services/speech-to-text/custom.html#languageSupport).</value>
        [JsonProperty("base_model_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BaseModelName { get; set; }
        /// <summary>
        /// The dialect of the specified language that is to be used with the custom language model. The parameter is meaningful only for Spanish models, for which the service creates a custom language model that is suited for speech in one of the following dialects: * `es-ES` for Castilian Spanish (the default) * `es-LA` for Latin American Spanish * `es-US` for North American (Mexican) Spanish   A specified dialect must be valid for the base model. By default, the dialect matches the language of the base model; for example, `en-US` for either of the US English language models.
        /// </summary>
        /// <value>The dialect of the specified language that is to be used with the custom language model. The parameter is meaningful only for Spanish models, for which the service creates a custom language model that is suited for speech in one of the following dialects: * `es-ES` for Castilian Spanish (the default) * `es-LA` for Latin American Spanish * `es-US` for North American (Mexican) Spanish   A specified dialect must be valid for the base model. By default, the dialect matches the language of the base model; for example, `en-US` for either of the US English language models.</value>
        [JsonProperty("dialect", NullValueHandling = NullValueHandling.Ignore)]
        public string Dialect { get; set; }
        /// <summary>
        /// A description of the new custom language model. Use a localized description that matches the language of the custom model.
        /// </summary>
        /// <value>A description of the new custom language model. Use a localized description that matches the language of the custom model.</value>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }
    }

}
