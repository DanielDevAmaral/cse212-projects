public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if (value < Data) {
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if (value > Data) {
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value) {

        if (value == Data)
            return true;
        else if (value < Data && Left != null)
        {
            return Left.Contains(value);
        }
        else if (value > Data && Right != null)
        {
            return Right.Contains(value);
        }
        else
        {
            return false;
        }

    }

    public int GetHeight() {
        // TODO Start Problem 4
        int lh;
        int rh;
        int maxH;
        if (Left != null)
        {
            lh = Left.GetHeight();
        }
        else
        {
            lh = 0;
        }
        if (Right != null)
        {
            rh = Right.GetHeight();
        }
        else
        {
            rh = 0;
        }
        if(lh > rh)
        {
            maxH = lh;
        }
        else
        {
            maxH = rh;
        }
        return 1 + maxH; // Replace this line with the correct return statement(s)
    }
}