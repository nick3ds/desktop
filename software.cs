internal class Software
{
    static int[] indices =
    {
        0, 40992, 81984, 122976, 163968, 204960, 245952, 286944,
        327936, 368928, 320, 41312, 82304, 123296, 164288, 205280,
        246272, 287264, 328256, 369248, 640, 41632, 82624, 123616,
    };

    static int[] vectors =
    {
        16, -106, 102, -70, -213, 7, -62, -108,
        -84, -216, 8, -41, 36, -119, 69, 81,
        75, -142, 25, -74, -71, 13, -15, -157,
    };

    static void Main(string[] args)
    {
        var positions = File.ReadAllBytes(args[0]);

        for (int i = 0; i < vectors.Length; i++)
        {
            var value = positions[indices[i]] + vectors[i];
            Console.Write((char)value);
        }
    }
}
