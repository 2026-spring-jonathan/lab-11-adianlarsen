using labyrinth;

public static class MazeExplorer
{
    public static IEnumerable<NodeLink> ExploreMaze(MazeCell start)
    {
        List<NodeLink>? nodeLinks = new List<NodeLink>(); 
        ExploreNode(start, nodeLinks);
        return nodeLinks;   
    }

    public static void ExploreNode(MazeCell current, List<NodeLink> links)
    {
        if(current is null)
        {
            return;
        }

        if(current.North is not null)
        {
            var northLink = new NodeLink(current, "North", current.North);
            if(!links.Contains(northLink))
            {
                links.Add(northLink);
                ExploreNode(current.North, links);
            }
        }

        if(current.East is not null)
        {
            var eastLink = new NodeLink(current, "East", current.East);
            if(!links.Contains(eastLink))
            {
                links.Add(eastLink);
                ExploreNode(current.East, links);
            }
        }

        if(current.South is not null)
        {
            var southLink = new NodeLink(current, "South", current.South);
            if(!links.Contains(southLink))
            {
                links.Add(southLink);
                ExploreNode(current.South, links);
            }
        }

        if(current.West is not null)
        {
            var westLink = new NodeLink(current, "West", current.West);
            if(!links.Contains(westLink))
            {
                links.Add(westLink);
                ExploreNode(current.West, links);
            }
        }
    }
}