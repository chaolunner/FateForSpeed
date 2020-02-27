// <auto-generated>
// THIS (.cs) FILE IS GENERATED BY MPC(MessagePack-CSharp). DO NOT CHANGE IT.
// </auto-generated>

#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168

#pragma warning disable SA1200 // Using directives should be placed correctly
#pragma warning disable SA1403 // File may only contain a single namespace
#pragma warning disable SA1649 // File name should match first type name

namespace MessagePack.Formatters.Common
{
    using System;
    using System.Buffers;
    using System.Collections.Generic;
    using MessagePack;

    public sealed class IInputFormatter : global::MessagePack.Formatters.IMessagePackFormatter<global::Common.IInput>
    {
        private readonly Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>> typeToKeyAndJumpMap;
        private readonly Dictionary<int, int> keyToJumpMap;

        public IInputFormatter()
        {
            this.typeToKeyAndJumpMap = new Dictionary<RuntimeTypeHandle, KeyValuePair<int, int>>(4, global::MessagePack.Internal.RuntimeTypeHandleEqualityComparer.Default)
            {
                { typeof(global::Common.EventInput).TypeHandle, new KeyValuePair<int, int>(0, 0) },
                { typeof(global::Common.AxisInput).TypeHandle, new KeyValuePair<int, int>(1, 1) },
                { typeof(global::Common.KeyInput).TypeHandle, new KeyValuePair<int, int>(2, 2) },
                { typeof(global::Common.MouseInput).TypeHandle, new KeyValuePair<int, int>(3, 3) },
            };
            this.keyToJumpMap = new Dictionary<int, int>(4)
            {
                { 0, 0 },
                { 1, 1 },
                { 2, 2 },
                { 3, 3 },
            };
        }

        public void Serialize(ref MessagePackWriter writer, global::Common.IInput value, global::MessagePack.MessagePackSerializerOptions options)
        {
            KeyValuePair<int, int> keyValuePair;
            if (value != null && this.typeToKeyAndJumpMap.TryGetValue(value.GetType().TypeHandle, out keyValuePair))
            {
                writer.WriteArrayHeader(2);
                writer.WriteInt32(keyValuePair.Key);
                switch (keyValuePair.Value)
                {
                    case 0:
                        options.Resolver.GetFormatterWithVerify<global::Common.EventInput>().Serialize(ref writer, (global::Common.EventInput)value, options);
                        break;
                    case 1:
                        options.Resolver.GetFormatterWithVerify<global::Common.AxisInput>().Serialize(ref writer, (global::Common.AxisInput)value, options);
                        break;
                    case 2:
                        options.Resolver.GetFormatterWithVerify<global::Common.KeyInput>().Serialize(ref writer, (global::Common.KeyInput)value, options);
                        break;
                    case 3:
                        options.Resolver.GetFormatterWithVerify<global::Common.MouseInput>().Serialize(ref writer, (global::Common.MouseInput)value, options);
                        break;
                    default:
                        break;
                }

                return;
            }

            writer.WriteNil();
        }

        public global::Common.IInput Deserialize(ref MessagePackReader reader, global::MessagePack.MessagePackSerializerOptions options)
        {
            if (reader.TryReadNil())
            {
                return null;
            }

            if (reader.ReadArrayHeader() != 2)
            {
                throw new InvalidOperationException("Invalid Union data was detected. Type:global::Common.IInput");
            }

            options.Security.DepthStep(ref reader);
            var key = reader.ReadInt32();

            if (!this.keyToJumpMap.TryGetValue(key, out key))
            {
                key = -1;
            }

            global::Common.IInput result = null;
            switch (key)
            {
                case 0:
                    result = (global::Common.IInput)options.Resolver.GetFormatterWithVerify<global::Common.EventInput>().Deserialize(ref reader, options);
                    break;
                case 1:
                    result = (global::Common.IInput)options.Resolver.GetFormatterWithVerify<global::Common.AxisInput>().Deserialize(ref reader, options);
                    break;
                case 2:
                    result = (global::Common.IInput)options.Resolver.GetFormatterWithVerify<global::Common.KeyInput>().Deserialize(ref reader, options);
                    break;
                case 3:
                    result = (global::Common.IInput)options.Resolver.GetFormatterWithVerify<global::Common.MouseInput>().Deserialize(ref reader, options);
                    break;
                default:
                    reader.Skip();
                    break;
            }

            reader.Depth--;
            return result;
        }
    }


}

#pragma warning restore 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612

#pragma warning restore SA1200 // Using directives should be placed correctly
#pragma warning restore SA1403 // File may only contain a single namespace
#pragma warning restore SA1649 // File name should match first type name
