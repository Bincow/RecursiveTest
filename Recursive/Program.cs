using Recursive;

class Program
    {
        static void Main(string[] args)
        {
            Branch rootBranch = new Branch();
            Branch branch1 = new Branch();
            Branch branch2 = new Branch();
            Branch branch3 = new Branch();
            Branch branch4 = new Branch();
            Branch branch5 = new Branch();
            Branch branch6 = new Branch();

            rootBranch.AddBranch(branch1);
            rootBranch.AddBranch(branch2);
            branch1.AddBranch(branch3);
            branch3.AddBranch(branch4);
            branch4.AddBranch(branch5);
            branch5.AddBranch(branch6);

            int depth = rootBranch.CalculateDepth();

            Console.WriteLine("Depth of the structure: " + depth);
        }
    }