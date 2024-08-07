int n; 
int[][] roads = new int[2][];
Dictionary<int, int> map = new Dictionary<int, int>();
for (int i = 0; i < roads.Length; i++)
{
    int cell = roads[i][0];
    map[cell] = map.GetValueOrDefault(cell, 0) + 1;
}
for (int i = 0; i < roads.Length; i++)
{
    int cell = roads[i][1];
    map[cell] = map.GetValueOrDefault(cell, 0) + 1;
}
var m = map.OrderByDescending