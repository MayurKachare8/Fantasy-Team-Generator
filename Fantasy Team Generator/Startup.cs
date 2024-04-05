using Fantasy_Team_Generator.Data;

public class Startup
{
    public static void Main(string[] args) {
        FantasyOperation fantasyOperation = new FantasyOperation();

        fantasyOperation.GetTeam();
    }
}