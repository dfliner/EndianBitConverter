namespace EndianBitConverter;

/// <summary>
/// This class auguments <see cref="BitConverter"/> to support endianness in conversion between data
/// value and its byte array. 
/// </summary>
/// <remarks>
/// <see cref="BitConverter"/> assumes that the byte arrys given to it are always in the system's 
/// native byte order. There are two implementations of this class to support little-endian and big-endian
/// byte order respective.
/// </remarks>
public abstract class EndianBitConverter
{
    private static Lazy<BigEndianBitConverter> lazyBigEndian = 
        new Lazy<BigEndianBitConverter>(() => new BigEndianBitConverter());
    
    private static Lazy<LittleEndianBitConverter> lazyLittleEndian = 
        new Lazy<LittleEndianBitConverter>(() => new LittleEndianBitConverter());

    /// <summary>
    /// Gets an <see cref="EndianBitConverter"/> to support little-endian byte order.
    /// </summary>
    public static EndianBitConverter LittleEndian => lazyLittleEndian.Value;

    /// <summary>
    /// Gets an <see cref="EndianBitConverter"/> to support big-endian byte order.
    /// </summary>
    public static EndianBitConverter BigEndian => lazyBigEndian.Value;

    /// <summary>
    /// Returns a byte array of the specified boolean value.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <returns>A byte array converted from the value.</returns>
    public abstract byte[] GetBytes(bool value);

    /// <summary>
    /// Returns a byte array of the specified Unicode character.
    /// </summary>
    /// <param name="value">The character to convert.</param>
    /// <returns>A byte array converted from the character value.</returns>
    public abstract byte[] GetBytes(char value);

    /// <summary>
    /// Returns a byte array of the specified 16-bit integer value.
    /// </summary>
    /// <param name="value">The number to convert.</param>
    /// <returns>A byte array converted from the number value.</returns>
    public abstract byte[] GetBytes(short value);

    /// <summary>
    /// Returns a byte array of the specified 16-bit integer value.
    /// </summary>
    /// <param name="value">The number to convert.</param>
    /// <returns>A byte array converted from the number value.</returns>
    public abstract byte[] GetBytes(ushort value);

    /// <summary>
    /// Returns a byte array of the specified 32-bit integer value.
    /// </summary>
    /// <param name="value">The number to convert.</param>
    /// <returns>A byte array converted from the number value.</returns>
    public abstract byte[] GetBytes(int value);

    /// <summary>
    /// Returns a byte array of the specified 32-bit integer value.
    /// </summary>
    /// <param name="value">The number to convert.</param>
    /// <returns>A byte array converted from the number value.</returns>
    public abstract byte[] GetBytes(uint value);

    /// <summary>
    /// Returns a byte array of the specified 64-bit integer value.
    /// </summary>
    /// <param name="value">The number to convert.</param>
    /// <returns>A byte array converted from the number value.</returns>
    public abstract byte[] GetBytes(long value);

    /// <summary>
    /// Returns a byte array of the specified 64-bit integer value.
    /// </summary>
    /// <param name="value">The number to convert.</param>
    /// <returns>A byte array converted from the number value.</returns>
    public abstract byte[] GetBytes(ulong value);

    /// <summary>
    /// Returns a byte array of the specified float value.
    /// </summary>
    /// <param name="value">The number to convert.</param>
    /// <returns>A byte array converted from the number value.</returns>
    public abstract byte[] GetBytes(float value);

    /// <summary>
    /// Returns a byte array of the specified double value.
    /// </summary>
    /// <param name="value">The number to convert.</param>
    /// <returns>A byte array converted from the number value.</returns>
    public abstract byte[] GetBytes(double value);

    /// <summary>
    /// Returns a byte array of the specified decimal value.
    /// </summary>
    /// <param name="value">The number to convert.</param>
    /// <returns>A byte array converted from the number value.</returns>
    public abstract byte[] GetBytes(decimal value);

    /// <summary>
    /// Returns a byte array of the specified Unicode string, using UTF-16 format.
    /// </summary>
    /// <param name="value">The string to convert.</param>
    /// <returns>A byte array converted from the string.</returns>
    public abstract byte[] GetUnicodeBytes(string value);

    /// <summary>
    /// Converts to a boolean value from the byte array starting at specified position.
    /// </summary>
    /// <param name="bytes">A byte array.</param>
    /// <param name="startIndex">The starting position within the byte array to convert.</param>
    /// <returns>The boolean value converted from the byte array.</returns>
    public abstract bool ToBoolean(byte[] bytes, int startIndex);

    /// <summary>
    /// Converts to a character value from the byte array starting at specified position.
    /// </summary>
    /// <param name="bytes">A byte array.</param>
    /// <param name="startIndex">The starting position within the byte array to convert.</param>
    /// <returns>The character value converted from the byte array.</returns>
    public abstract char ToChar(byte[] bytes, int startIndex);

    /// <summary>
    /// Converts to a 16-bit integter value from the byte array starting at specified position.
    /// </summary>
    /// <param name="bytes">A byte array.</param>
    /// <param name="startIndex">The starting position within the byte array to convert.</param>
    /// <returns>The number value converted from the byte array.</returns>
    public abstract short ToInt16(byte[] bytes, int startIndex);

    /// <summary>
    /// Converts to a 16-bit integter value from the byte array starting at specified position.
    /// </summary>
    /// <param name="bytes">A byte array.</param>
    /// <param name="startIndex">The starting position within the byte array to convert.</param>
    /// <returns>The number value converted from the byte array.</returns>
    public abstract ushort ToUInt16(byte[] bytes, int startIndex);

    /// <summary>
    /// Converts to a 32-bit integter value from the byte array starting at specified position.
    /// </summary>
    /// <param name="bytes">A byte array.</param>
    /// <param name="startIndex">The starting position within the byte array to convert.</param>
    /// <returns>The number value converted from the byte array.</returns>
    public abstract int ToInt32(byte[] bytes, int startIndex);

    /// <summary>
    /// Converts to a 32-bit integter value from the byte array starting at specified position.
    /// </summary>
    /// <param name="bytes">A byte array.</param>
    /// <param name="startIndex">The starting position within the byte array to convert.</param>
    /// <returns>The number value converted from the byte array.</returns>
    public abstract uint ToUInt32(byte[] bytes, int startIndex);

    /// <summary>
    /// Converts to a 64-bit integter value from the byte array starting at specified position.
    /// </summary>
    /// <param name="bytes">A byte array.</param>
    /// <param name="startIndex">The starting position within the byte array to convert.</param>
    /// <returns>The number value converted from the byte array.</returns>
    public abstract long ToInt64(byte[] bytes, int startIndex);

    /// <summary>
    /// Converts to a 64-bit integter value from the byte array starting at specified position.
    /// </summary>
    /// <param name="bytes">A byte array.</param>
    /// <param name="startIndex">The starting position within the byte array to convert.</param>
    /// <returns>The number value converted from the byte array.</returns>
    public abstract ulong ToUInt64(byte[] bytes, int startIndex);

    /// <summary>
    /// Converts to a float value from the byte array starting at specified position.
    /// </summary>
    /// <param name="bytes">A byte array.</param>
    /// <param name="startIndex">The starting position within the byte array to convert.</param>
    /// <returns>The number value converted from the byte array.</returns>
    public abstract float ToSingle(byte[] bytes, int startIndex);

    /// <summary>
    /// Converts to a double value from the byte array starting at specified position.
    /// </summary>
    /// <param name="bytes">A byte array.</param>
    /// <param name="startIndex">The starting position within the byte array to convert.</param>
    /// <returns>The number value converted from the byte array.</returns>
    public abstract double ToDouble(byte[] bytes, int startIndex);

    /// <summary>
    /// Converts to a decimal value from the byte array starting at specified position.
    /// </summary>
    /// <param name="bytes">A byte array.</param>
    /// <param name="startIndex">The starting position within the byte array to convert.</param>
    /// <returns>The number value converted from the byte array.</returns>
    public abstract decimal ToDecimal(byte[] bytes, int startIndex);

    /// <summary>
    /// Converts to a Unicode string from the byte array starting at specified position.
    /// </summary>
    /// <param name="bytes">A byte array of UTF-16 format.</param>
    /// <param name="startIndex">The starting position within the byte array to convert.</param>
    /// <returns>The Unicode string converted from the byte array.</returns>
    public abstract string ToString(byte[] bytes, int startIndex, int count);
}
