namespace Algorithms_CS.Problems
{
    // Given the root of a binary tree, return the level order traversal of its nodes' values.
    // (i.e., from left to right, level by level).
    //
    // Example 1:
    // Input: root = [3,9,20,null,null,15,7]
    // Output: [[3],[9,20],[15,7]]
    //
    // Example 2:
    // Input: root = [1]
    // Output: [[1]]
    //
    // Example 3:
    // Input: root = []
    // Output: []
    public class BinaryTreeLevelOrderTraversal
    {

        // realization BFS version
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            List<IList<int>> list = new List<IList<int>>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            if (root == null) return list;
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int size = queue.Count;
                IList<int> currentLevel = new List<int>();
                for (int i = 0; i < size; i++)
                {
                    TreeNode node = queue.Dequeue();

                    currentLevel.Add(node.val);

                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                }
                list.Add(currentLevel);
            }
            return list;
        }



        // realization DFS version
        public IList<IList<int>> LevelOrderDFS(TreeNode root)
        {
            List<IList<int>> list = new List<IList<int>>();
            
            int grade = 0;
            Order(root, grade, ref list);
            return list;
        }

        public void Order(TreeNode node, int grade, ref List<IList<int>> list)
        {
            if (node == null)
            {
                grade--;
                return;
            }

            if(list.Count - 1 < grade)
            {
                IList<int> currentLevel = new List<int>();
                list.Add(currentLevel);               
            }
            list[grade++].Add(node.val);

            Order(node.left, grade,  ref list);
            Order(node.right, grade,  ref list);
        }

    }
}
