namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    public partial class Machine
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IMachine.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IMachine.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.IMachine FromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject json ? new Machine(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject into a new instance of <see cref="Machine" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal Machine(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_propertiesAgent = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject>("properties.agent"), out var __jsonPropertiesAgent) ? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.AgentConfiguration.FromJson(__jsonPropertiesAgent) : PropertiesAgent;}
            {_propertiesHosting = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject>("properties.hosting"), out var __jsonPropertiesHosting) ? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.HostingConfiguration.FromJson(__jsonPropertiesHosting) : PropertiesHosting;}
            {_propertiesHypervisor = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject>("properties.hypervisor"), out var __jsonPropertiesHypervisor) ? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.HypervisorConfiguration.FromJson(__jsonPropertiesHypervisor) : PropertiesHypervisor;}
            {_propertiesNetworking = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject>("properties.networking"), out var __jsonPropertiesNetworking) ? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.NetworkConfiguration.FromJson(__jsonPropertiesNetworking) : PropertiesNetworking;}
            {_propertiesOperatingSystem = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject>("properties.operatingSystem"), out var __jsonPropertiesOperatingSystem) ? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.OperatingSystemConfiguration.FromJson(__jsonPropertiesOperatingSystem) : PropertiesOperatingSystem;}
            {_propertiesResource = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject>("properties.resources"), out var __jsonPropertiesResources) ? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.MachineResourcesConfiguration.FromJson(__jsonPropertiesResources) : PropertiesResource;}
            {_propertiesTimezone = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject>("properties.timezone"), out var __jsonPropertiesTimezone) ? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.Timezone.FromJson(__jsonPropertiesTimezone) : PropertiesTimezone;}
            {_propertiesVirtualMachine = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject>("properties.virtualMachine"), out var __jsonPropertiesVirtualMachine) ? Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api202001.VirtualMachineConfiguration.FromJson(__jsonPropertiesVirtualMachine) : PropertiesVirtualMachine;}
            {_name = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)Name;}
            {_type = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("type"), out var __jsonType) ? (string)__jsonType : (string)Type;}
            {_etag = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("etag"), out var __jsonEtag) ? (string)__jsonEtag : (string)Etag;}
            {_id = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("id"), out var __jsonId) ? (string)__jsonId : (string)Id;}
            {_propertiesBootTime = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("properties.bootTime"), out var __jsonPropertiesBootTime) ? global::System.DateTime.TryParse((string)__jsonPropertiesBootTime, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonPropertiesBootTimeValue) ? __jsonPropertiesBootTimeValue : PropertiesBootTime : PropertiesBootTime;}
            {_propertiesComputerName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("properties.computerName"), out var __jsonPropertiesComputerName) ? (string)__jsonPropertiesComputerName : (string)PropertiesComputerName;}
            {_propertiesDisplayName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("properties.displayName"), out var __jsonPropertiesDisplayName) ? (string)__jsonPropertiesDisplayName : (string)PropertiesDisplayName;}
            {_propertiesFullyQualifiedDomainName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("properties.fullyQualifiedDomainName"), out var __jsonPropertiesFullyQualifiedDomainName) ? (string)__jsonPropertiesFullyQualifiedDomainName : (string)PropertiesFullyQualifiedDomainName;}
            {_propertiesMonitoringState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("properties.monitoringState"), out var __jsonPropertiesMonitoringState) ? (string)__jsonPropertiesMonitoringState : (string)PropertiesMonitoringState;}
            {_propertiesTimestamp = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("properties.timestamp"), out var __jsonPropertiesTimestamp) ? global::System.DateTime.TryParse((string)__jsonPropertiesTimestamp, global::System.Globalization.CultureInfo.InvariantCulture, global::System.Globalization.DateTimeStyles.AdjustToUniversal, out var __jsonPropertiesTimestampValue) ? __jsonPropertiesTimestampValue : PropertiesTimestamp : PropertiesTimestamp;}
            {_propertiesVirtualizationState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString>("properties.virtualizationState"), out var __jsonPropertiesVirtualizationState) ? (string)__jsonPropertiesVirtualizationState : (string)PropertiesVirtualizationState;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="Machine" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="Machine" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._propertiesAgent ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) this._propertiesAgent.ToJson(null,serializationMode) : null, "properties.agent" ,container.Add );
            AddIf( null != this._propertiesHosting ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) this._propertiesHosting.ToJson(null,serializationMode) : null, "properties.hosting" ,container.Add );
            AddIf( null != this._propertiesHypervisor ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) this._propertiesHypervisor.ToJson(null,serializationMode) : null, "properties.hypervisor" ,container.Add );
            AddIf( null != this._propertiesNetworking ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) this._propertiesNetworking.ToJson(null,serializationMode) : null, "properties.networking" ,container.Add );
            AddIf( null != this._propertiesOperatingSystem ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) this._propertiesOperatingSystem.ToJson(null,serializationMode) : null, "properties.operatingSystem" ,container.Add );
            AddIf( null != this._propertiesResource ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) this._propertiesResource.ToJson(null,serializationMode) : null, "properties.resources" ,container.Add );
            AddIf( null != this._propertiesTimezone ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) this._propertiesTimezone.ToJson(null,serializationMode) : null, "properties.timezone" ,container.Add );
            AddIf( null != this._propertiesVirtualMachine ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) this._propertiesVirtualMachine.ToJson(null,serializationMode) : null, "properties.virtualMachine" ,container.Add );
            AddIf( null != (((object)this._name)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._name.ToString()) : null, "name" ,container.Add );
            AddIf( null != (((object)this._type)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._type.ToString()) : null, "type" ,container.Add );
            AddIf( null != (((object)this._etag)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._etag.ToString()) : null, "etag" ,container.Add );
            AddIf( null != (((object)this._id)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._id.ToString()) : null, "id" ,container.Add );
            AddIf( null != this._propertiesBootTime ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._propertiesBootTime?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "properties.bootTime" ,container.Add );
            AddIf( null != (((object)this._propertiesComputerName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._propertiesComputerName.ToString()) : null, "properties.computerName" ,container.Add );
            AddIf( null != (((object)this._propertiesDisplayName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._propertiesDisplayName.ToString()) : null, "properties.displayName" ,container.Add );
            AddIf( null != (((object)this._propertiesFullyQualifiedDomainName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._propertiesFullyQualifiedDomainName.ToString()) : null, "properties.fullyQualifiedDomainName" ,container.Add );
            AddIf( null != (((object)this._propertiesMonitoringState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._propertiesMonitoringState.ToString()) : null, "properties.monitoringState" ,container.Add );
            AddIf( null != this._propertiesTimestamp ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._propertiesTimestamp?.ToString(@"yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK",global::System.Globalization.CultureInfo.InvariantCulture)) : null, "properties.timestamp" ,container.Add );
            AddIf( null != (((object)this._propertiesVirtualizationState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonString(this._propertiesVirtualizationState.ToString()) : null, "properties.virtualizationState" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}