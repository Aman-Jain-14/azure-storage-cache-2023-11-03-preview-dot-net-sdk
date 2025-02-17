// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.SecurityInsights.Models;

namespace Azure.ResourceManager.SecurityInsights
{
    public partial class SecurityInsightsThreatIntelligenceIndicatorBaseData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static SecurityInsightsThreatIntelligenceIndicatorBaseData DeserializeSecurityInsightsThreatIntelligenceIndicatorBaseData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "indicator": return SecurityInsightsThreatIntelligenceIndicatorData.DeserializeSecurityInsightsThreatIntelligenceIndicatorData(element);
                }
            }
            return UnknownThreatIntelligenceInformation.DeserializeUnknownThreatIntelligenceInformation(element);
        }
    }
}
