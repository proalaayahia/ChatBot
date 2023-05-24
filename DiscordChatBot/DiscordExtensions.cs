using DSharpPlus;

public static class DiscordExtensions
{
    private static AlaBot _Bot;

    public static DiscordClient AddAlaBot(this DiscordClient client)
    {
        _Bot = new AlaBot();
        _Bot.Initialize(client);

        return client;
    }
}