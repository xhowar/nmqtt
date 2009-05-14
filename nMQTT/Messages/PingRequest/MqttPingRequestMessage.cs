﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Nmqtt
{
    /// <summary>
    /// Implementation of an MQTT Ping Request Message.
    /// </summary>
    public sealed class MqttPingRequestMessage : MqttMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MqttPublishMessage"/> class.
        /// </summary>
        /// <remarks>
        /// Only called via the MqttMessage.Create operation during processing of an Mqtt message stream.
        /// </remarks>
        public MqttPingRequestMessage()
        {
            this.Header = new MqttHeader().AsType(MqttMessageType.PingRequest);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MqttConnectMessage"/> class.
        /// </summary>
        /// <param name="messageStream">The message stream positioned after the header.</param>
        internal MqttPingRequestMessage(MqttHeader header)
        {
            this.Header = header;
        }

        /// <summary>
        /// Returns a <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String"/> that represents the current <see cref="T:System.Object"/>.
        /// </returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            return sb.ToString();
        }
    }
}