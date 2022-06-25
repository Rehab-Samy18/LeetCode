public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
        IList<int> result = new List<int>();
        if(matrix!=null||matrix.Length>0)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;
            int TopRow = 0;
            int RightColumn = n - 1;
            int BottomRow = m - 1;
            int LeftColumn = 0;
            int dir = 1;
            
            while(result.Count < m * n)
            {
                //Top Row From Left To Right
                if(dir == 1)
                {
                    var row = matrix[TopRow];
                    for(int i = LeftColumn; i <= RightColumn; i++)
                    {
                        result.Add(row[i]);
                    }
                    TopRow++;
                    dir = 2;
                }
                //Right Column From Top To Bottom
                else if(dir == 2)
                {
                    for(int i = TopRow; i <= BottomRow; i++)
                    {
                        result.Add(matrix[i][RightColumn]);
                    }
                    RightColumn--;
                    dir = 3;
                }
                else if(dir == 3)
                {
                    var row = matrix[BottomRow];
                    for(int i = RightColumn; i >= LeftColumn; i--)
                    {
                        result.Add(row[i]);
                    }
                    BottomRow--;
                    dir = 4;
                }
                else if(dir == 4)
                {
                    for(int i = BottomRow; i >= TopRow; i--)
                    {
                        result.Add(matrix[i][LeftColumn]);
                    }
                    LeftColumn++;
                    dir = 1;
                }
            }
        }
        return result;
        
    }
}