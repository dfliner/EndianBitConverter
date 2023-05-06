# EndianBitConverter

The .NET built-in [BitConverter](https://learn.microsoft.com/en-us/dotnet/api/system.bitconverter) uses the system's endianness to interpret the order of bytes in byte arrays converted from/to data values. This requires the developer to take care of the byte order while transfering data between systems with different endianness. 

This <code>EndianBitConverter</code> provides "endianness-aware" implementations that always intepret the order of bytes in the byte arrays as either little-endian or big-endian, regardless of the system's endianness:

- LittleEndian: The <code>LittleEndian</code> property provides an implementation that always processes the byte arrays in little-endian order.
- BigEndian: The <code>BigEndian</code> property provides an implementation that always processes the byte arrays in big-endian order.
