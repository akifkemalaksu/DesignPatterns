public class Forest
{
    private List<Tree> _trees = new List<Tree>();

    public void PlantTree(int x, int y, string name, string color, string texture, TreeFactory factory)
    {
        TreeType type = factory.GetTreeType(name, color, texture);
        Tree tree = new Tree(x, y, type);
        _trees.Add(tree);
    }

    public void Draw()
    {
        foreach (var tree in _trees)
        {
            tree.Type.Draw(tree.X, tree.Y);
        }
    }
}