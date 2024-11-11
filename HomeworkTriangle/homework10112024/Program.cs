Console.Write("h= ");
int height = int.Parse(Console.ReadLine());
Console.Write("pos= ");
string side = Console.ReadLine();

int sideACords = 0;
int sideBCords = 0;

Console.Clear();

switch (side)
{
    case "left":
        //printing left side of triangle
        for (int i = 1; i < height; i++)
        {
            Console.WriteLine("*");
        }
        //printing right side of triangle
        for (int i = 0; i < height; i++)
        {
            Console.Write("*");
        }
        //printing bottom of triangle
        for (int i = 0; i < height; i++)
        {
            Console.SetCursorPosition(sideACords, sideBCords);
            Console.Write("*");
            sideACords++;
            sideBCords++;
        }
        break;

    case "right":

        sideACords = height;
        //printing right side of triangle
        for (int i = 1; i < height; i++)
        {
            Console.SetCursorPosition(height - 1, i);
            Console.WriteLine("*");
        }
        //printing left side of triangle
        for (int i = 0; i < height; i++)
        {
            Console.SetCursorPosition(sideACords - 1, sideBCords);
            Console.Write("*");
            sideACords--;
            sideBCords++;
        }
        //printing bottom of triangle
        for (int i = 0; i < height; i++)
        {
            Console.SetCursorPosition(i, height - 1);
            Console.Write("*");
        }
        break;
    //checking if the pos is valid
    default:
        Console.WriteLine("Invalid position!");
        break;
}