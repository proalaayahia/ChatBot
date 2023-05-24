using DSharpPlus;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

var config = new ConfigurationBuilder()
    //.AddJsonFile("appsettings.json", false)
    .AddUserSecrets(typeof(Program).Assembly, true)
    .Build();

var discord = new DiscordClient(new DiscordConfiguration
{
    AutoReconnect = true,
    MinimumLogLevel = LogLevel.Debug,

    Token = config["discordToken"],
    TokenType = TokenType.Bot
});
discord.AddAlaBot();

await discord.ConnectAsync();
await Task.Delay(-1);