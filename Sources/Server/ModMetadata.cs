using System.Collections.Generic;
using SPTarkov.Server.Core.Models.Spt.Mod;
using SwiftXP.SPT.Common.Runtime;

namespace SwiftXP.SPT.ShowMeTheMoney.Server;

public record ModMetadata : IModMetadata
{
    public string ModGuid { get; init; } = "com.dark.spt.showmethemoney";
    public string Name { get; init; } = "Show Me The Money";
    public string Author { get; init; } = "SwiftXP";
    public List<string>? Contributors { get; init; } = [];
    public SemanticVersioning.Version Version { get; init; } = new(AppMetadata.Version);
    public SemanticVersioning.Range SptVersion { get; init; } = new("~4.1.0");
    public bool HasPrepatcher { get; init; }

    public List<string>? Incompatibilities { get; init; } = [];
    public Dictionary<string, SemanticVersioning.Range>? ModDependencies { get; init; } = [];
    public string? Url { get; init; } = "https://github.com/swiftxp-hub/spt-show-me-the-money";
    public string License { get; init; } = "MIT";
}
