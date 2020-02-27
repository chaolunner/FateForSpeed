// <auto-generated>
// THIS (.cs) FILE IS GENERATED BY MPC(MessagePack-CSharp). DO NOT CHANGE IT.
// </auto-generated>

#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 168

#pragma warning disable SA1129 // Do not use default value type constructor
#pragma warning disable SA1200 // Using directives should be placed correctly
#pragma warning disable SA1309 // Field names should not begin with underscore
#pragma warning disable SA1312 // Variable names should begin with lower-case letter
#pragma warning disable SA1403 // File may only contain a single namespace
#pragma warning disable SA1649 // File name should match first type name

namespace MessagePack.Formatters.Common
{
    using System;
    using System.Buffers;
    using MessagePack;

    public sealed class FixVector3Formatter : global::MessagePack.Formatters.IMessagePackFormatter<global::Common.FixVector3>
    {


        public void Serialize(ref MessagePackWriter writer, global::Common.FixVector3 value, global::MessagePack.MessagePackSerializerOptions options)
        {
            IFormatterResolver formatterResolver = options.Resolver;
            writer.WriteArrayHeader(3);
            formatterResolver.GetFormatterWithVerify<global::Common.Fix64>().Serialize(ref writer, value.x, options);
            formatterResolver.GetFormatterWithVerify<global::Common.Fix64>().Serialize(ref writer, value.y, options);
            formatterResolver.GetFormatterWithVerify<global::Common.Fix64>().Serialize(ref writer, value.z, options);
        }

        public global::Common.FixVector3 Deserialize(ref MessagePackReader reader, global::MessagePack.MessagePackSerializerOptions options)
        {
            if (reader.TryReadNil())
            {
                throw new InvalidOperationException("typecode is null, struct not supported");
            }

            options.Security.DepthStep(ref reader);
            IFormatterResolver formatterResolver = options.Resolver;
            var length = reader.ReadArrayHeader();
            var __x__ = default(global::Common.Fix64);
            var __y__ = default(global::Common.Fix64);
            var __z__ = default(global::Common.Fix64);

            for (int i = 0; i < length; i++)
            {
                var key = i;

                switch (key)
                {
                    case 0:
                        __x__ = formatterResolver.GetFormatterWithVerify<global::Common.Fix64>().Deserialize(ref reader, options);
                        break;
                    case 1:
                        __y__ = formatterResolver.GetFormatterWithVerify<global::Common.Fix64>().Deserialize(ref reader, options);
                        break;
                    case 2:
                        __z__ = formatterResolver.GetFormatterWithVerify<global::Common.Fix64>().Deserialize(ref reader, options);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }

            var ____result = new global::Common.FixVector3(__x__, __y__, __z__);
            ____result.x = __x__;
            ____result.y = __y__;
            ____result.z = __z__;
            reader.Depth--;
            return ____result;
        }
    }
}

#pragma warning restore 168
#pragma warning restore 414
#pragma warning restore 618
#pragma warning restore 612

#pragma warning restore SA1129 // Do not use default value type constructor
#pragma warning restore SA1200 // Using directives should be placed correctly
#pragma warning restore SA1309 // Field names should not begin with underscore
#pragma warning restore SA1312 // Variable names should begin with lower-case letter
#pragma warning restore SA1403 // File may only contain a single namespace
#pragma warning restore SA1649 // File name should match first type name
