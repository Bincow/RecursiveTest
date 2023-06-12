namespace Recursive
{
    public class Branch
    {
        List<Branch> branches = new List<Branch>();

        public void AddBranch(Branch branch)
        {
            branches.Add(branch);
        }

        public int CalculateDepth()
        {
            if (branches.Count == 0)
            {
                return 1;
            }

            int maxDepth = 0;
            foreach (var branch in branches)
            {
                int depth = branch.CalculateDepth();
                maxDepth = Math.Max(maxDepth, depth);
            }

            return maxDepth + 1;
        }
    }
}