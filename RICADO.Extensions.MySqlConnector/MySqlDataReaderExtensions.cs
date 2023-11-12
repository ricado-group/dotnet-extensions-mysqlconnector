using System;
using MySqlConnector;

namespace RICADO.Extensions.MySqlConnector
{
    public static class MySqlDataReaderExtensions
    {
        public static bool IsDBNull(this MySqlDataReader reader, string name) => reader.IsDBNull(reader.GetOrdinal(name));

        public static bool? GetNullableBoolean(this MySqlDataReader reader, string name) => reader.IsDBNull(name) ? null : reader.GetBoolean(name);

        public static sbyte? GetNullableSByte(this MySqlDataReader reader, string name) => reader.IsDBNull(name) ? null : reader.GetSByte(name);

        public static byte? GetNullableByte(this MySqlDataReader reader, string name) => reader.IsDBNull(name) ? null : reader.GetByte(name);

        public static short? GetNullableInt16(this MySqlDataReader reader, string name) => reader.IsDBNull(name) ? null : reader.GetInt16(name);

        public static ushort? GetNullableUInt16(this MySqlDataReader reader, string name) => reader.IsDBNull(name) ? null : reader.GetUInt16(name);

        public static int? GetNullableInt32(this MySqlDataReader reader, string name) => reader.IsDBNull(name) ? null : reader.GetInt32(name);

        public static uint? GetNullableUInt32(this MySqlDataReader reader, string name) => reader.IsDBNull(name) ? null : reader.GetUInt32(name);

        public static long? GetNullableInt64(this MySqlDataReader reader, string name) => reader.IsDBNull(name) ? null : reader.GetInt64(name);

        public static ulong? GetNullableUInt64(this MySqlDataReader reader, string name) => reader.IsDBNull(name) ? null : reader.GetUInt64(name);

        public static double? GetNullableDouble(this MySqlDataReader reader, string name) => reader.IsDBNull(name) ? null : reader.GetDouble(name);

        public static float? GetNullableFloat(this MySqlDataReader reader, string name) => reader.IsDBNull(name) ? null : reader.GetFloat(name);

        public static decimal? GetNullableDecimal(this MySqlDataReader reader, string name) => reader.IsDBNull(name) ? null : reader.GetDecimal(name);

        public static string GetNullableString(this MySqlDataReader reader, string name) => reader.IsDBNull(name) ? null : reader.GetString(name);

        public static char? GetNullableChar(this MySqlDataReader reader, string name) => reader.IsDBNull(name) ? null : reader.GetChar(name);

        public static Guid? GetNullableGuid(this MySqlDataReader reader, string name) => reader.IsDBNull(name) ? null : reader.GetGuid(name);

        public static DateTime? GetNullableDateTime(this MySqlDataReader reader, string name) => reader.IsDBNull(name) ? null : reader.GetDateTime(name);

        public static DateTimeOffset? GetNullableDateTimeOffset(this MySqlDataReader reader, string name) => reader.IsDBNull(name) ? null : reader.GetDateTimeOffset(name);

        public static TimeSpan? GetNullableTimeSpan(this MySqlDataReader reader, string name) => reader.IsDBNull(name) ? null : reader.GetTimeSpan(name);

        public static T GetFieldValue<T>(this MySqlDataReader reader, string name)
        {
            if (typeof(T) == typeof(bool))
                return (T)(object)reader.GetBoolean(name);
            if (typeof(T) == typeof(bool?))
                return (T)(object)reader.GetNullableBoolean(name);
            if (typeof(T) == typeof(byte))
                return (T)(object)reader.GetByte(name);
            if (typeof(T) == typeof(byte?))
                return (T)(object)reader.GetNullableByte(name);
            if (typeof(T) == typeof(sbyte))
                return (T)(object)reader.GetSByte(name);
            if (typeof(T) == typeof(sbyte?))
                return (T)(object)reader.GetNullableSByte(name);
            if (typeof(T) == typeof(short))
                return (T)(object)reader.GetInt16(name);
            if (typeof(T) == typeof(short?))
                return (T)(object)reader.GetNullableInt16(name);
            if (typeof(T) == typeof(ushort))
                return (T)(object)reader.GetUInt16(name);
            if (typeof(T) == typeof(ushort?))
                return (T)(object)reader.GetNullableUInt16(name);
            if (typeof(T) == typeof(int))
                return (T)(object)reader.GetInt32(name);
            if (typeof(T) == typeof(int?))
                return (T)(object)reader.GetNullableInt32(name);
            if (typeof(T) == typeof(uint))
                return (T)(object)reader.GetUInt32(name);
            if (typeof(T) == typeof(uint?))
                return (T)(object)reader.GetNullableUInt32(name);
            if (typeof(T) == typeof(long))
                return (T)(object)reader.GetInt64(name);
            if (typeof(T) == typeof(long?))
                return (T)(object)reader.GetNullableInt64(name);
            if (typeof(T) == typeof(ulong))
                return (T)(object)reader.GetUInt64(name);
            if (typeof(T) == typeof(ulong?))
                return (T)(object)reader.GetNullableUInt64(name);
            if (typeof(T) == typeof(char))
                return (T)(object)reader.GetChar(name);
            if (typeof(T) == typeof(char?))
                return (T)(object)reader.GetNullableChar(name);
            if (typeof(T) == typeof(decimal))
                return (T)(object)reader.GetDecimal(name);
            if (typeof(T) == typeof(decimal?))
                return (T)(object)reader.GetNullableDecimal(name);
            if (typeof(T) == typeof(double))
                return (T)(object)reader.GetDouble(name);
            if (typeof(T) == typeof(double?))
                return (T)(object)reader.GetNullableDouble(name);
            if (typeof(T) == typeof(float))
                return (T)(object)reader.GetFloat(name);
            if (typeof(T) == typeof(float?))
                return (T)(object)reader.GetNullableFloat(name);
            if (typeof(T) == typeof(string))
                return (T)(object)reader.GetNullableString(name);
            if (typeof(T) == typeof(DateTime))
                return (T)(object)reader.GetDateTime(name);
            if (typeof(T) == typeof(DateTime?))
                return (T)(object)reader.GetNullableDateTime(name);
            if (typeof(T) == typeof(DateTimeOffset))
                return (T)(object)reader.GetDateTimeOffset(name);
            if (typeof(T) == typeof(DateTimeOffset?))
                return (T)(object)reader.GetNullableDateTimeOffset(name);
            if (typeof(T) == typeof(Guid))
                return (T)(object)reader.GetGuid(name);
            if (typeof(T) == typeof(Guid?))
                return (T)(object)reader.GetNullableGuid(name);
            if (typeof(T) == typeof(TimeSpan))
                return (T)(object)reader.GetTimeSpan(name);
            if (typeof(T) == typeof(TimeSpan?))
                return (T)(object)reader.GetNullableTimeSpan(name);

            return reader.GetFieldValue<T>(reader.GetOrdinal(name));
        }
    }
}
