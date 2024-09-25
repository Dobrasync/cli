/////////////////////////////////////////////////////////////////
//															   //
// This code is generated by a tool                            //
// https://github.com/StevenThuriot/dotnet-openapi-generator   //
//															   //
/////////////////////////////////////////////////////////////////

#nullable enable

#pragma warning disable CS8618 // Non-nullable variable must contain a non-null value when exiting constructor. Consider declaring it as nullable.

namespace Lamashare.CLI.ApiGen.Models;

[System.CodeDom.Compiler.GeneratedCode("dotnet-openapi-generator", "8.0.0-preview.15+2dc8cfca012adb9b7e1a243f167db99da7b5cfe4")]
[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public sealed class LibraryDto : __ICanIterate
{
    [System.Text.Json.Serialization.JsonConstructor] public LibraryDto() { }

    public LibraryDto(System.Guid id)
    {
        Id = id;
    }

	public System.Guid Id { get; set; }
	public string? Name { get; set; }

	System.Collections.Generic.IEnumerable<(string name, object? value)> __ICanIterate.IterateProperties()
	{
		yield return ("id", Id);
		yield return ("name", Name);
	}
}
