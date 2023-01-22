
using Google.Protobuf;
using System;
using System.Collections.Generic;
using Myworld;

namespace Proto
{
    public class ProtoDic
    {
        private static readonly Dictionary<int, Type> CMDs = new Dictionary<int, Type>
        {
            { 101, typeof(RegisterRequest) },
            { 102, typeof(RegisterResponse) },
            { 103, typeof(LoginRequest) },
            { 104, typeof(LoginResponse) },
            { 105, typeof(ExitRequest) },
            { 106, typeof(ExitResponse) },
        };

        private static readonly Dictionary<RuntimeTypeHandle, MessageParser> Parsers =
            new Dictionary<RuntimeTypeHandle, MessageParser>()
            {
                { typeof(RegisterRequest).TypeHandle, RegisterRequest.Parser },
                { typeof(RegisterResponse).TypeHandle, RegisterResponse.Parser },
                { typeof(LoginRequest).TypeHandle, LoginRequest.Parser },
                { typeof(LoginResponse).TypeHandle, LoginResponse.Parser },
                { typeof(ExitRequest).TypeHandle, ExitRequest.Parser },
                { typeof(ExitResponse).TypeHandle, ExitResponse.Parser },
            };

        public static MessageParser GetMessageParser(RuntimeTypeHandle typeHandle)
        {
            MessageParser messageParser;
            Parsers.TryGetValue(typeHandle, out messageParser);
            return messageParser;
        }

        public static Type GetProtoTypeByProtoId(int id)
        {
            if (CMDs.ContainsKey(id))
            {
                return CMDs[id];
            }
            return null;
        }

        public static int GetProtoIdByProtoType(Type type)
        {
            foreach (var CMD in CMDs)
            {
                if (CMD.Value == type)
                {
                    return CMD.Key;
                }
            }
            return 0;
        }

        public static bool ContainProtoId(int id)
        {
            return CMDs.ContainsKey(id);
        }

        public static bool ContainProtoType(Type type)
        {
            return CMDs.ContainsValue(type);
        }
    }
}