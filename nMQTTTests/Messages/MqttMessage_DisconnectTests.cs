﻿/* 
 * nMQTT, a .Net MQTT v3 client implementation.
 * 
 * Copyright (c) 2009 Mark Allanson (mark@markallanson.net)
 *
 * Licensed under the MIT License. You may not use this file except 
 * in compliance with the License. You may obtain a copy of the License at
 *
 *     http://www.opensource.org/licenses/mit-license.php
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using Nmqtt;

namespace NmqttTests
{
    /// <summary>
    /// MQTT Message Tests with sample input data provided by andy@stanford-clark.com
    /// </summary>
    public class MqttMessage_DisconnectTests
    {
        /// <summary>
        /// Tests basic message deserialization from a raw byte array.
        /// </summary>
        [Fact]
        public void Deserialize_Message_MessageType_Disconnect()
        {
            // Message Specs________________
            // <E0><00>
            var sampleMessage = new[]
            {
                (byte)0xE0,
                (byte)0x00
            };

            MqttMessage baseMessage = MqttMessage.CreateFrom(sampleMessage);

            Console.WriteLine(baseMessage.ToString());

            // check that the message was correctly identified as a connect message.
            Assert.IsType<MqttDisconnectMessage>(baseMessage);
        }
    } 
}
