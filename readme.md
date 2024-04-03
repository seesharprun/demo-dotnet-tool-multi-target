# Demo of a multi-targeted .NET tool

The .NET tool is developed in .NET 8, but you can install it in .NET 6 or 7 environments using the included devcontainer specifications.

## Included environments

| Version | Link to devcontainer spec | Open in GitHub Codespaces |
| --- | --- | --- |
| .NET 6 | [net60/devcontainer.json](.devcontainer/net60/devcontainer.json) | [![Open in GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/seesharprun/demo-dotnet-tool-multi-target?devcontainer_path=.devcontainer%2Fnet60%2Fdevcontainer.json) |
| .NET 7 | [net70/devcontainer.json](.devcontainer/net70/devcontainer.json) | [![Open in GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/seesharprun/demo-dotnet-tool-multi-target?devcontainer_path=.devcontainer%2Fnet70%2Fdevcontainer.json) |
| .NET 8 | [net80/devcontainer.json](.devcontainer/net80/devcontainer.json) | [![Open in GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/seesharprun/demo-dotnet-tool-multi-target?devcontainer_path=.devcontainer%2Fnet80%2Fdevcontainer.json) |

## Test

To test this process, follow these steps:

1. Package the multi-targeted project on your local .NET 8 machine:

    ```shell
    cd src/tool
    dotnet pack
    ```

1. The package will be in the `src/tool/nupkg/` folder.

1. Open any of the three devcontainer images in a GitHub Codespace.

1. Validate your version of .NET

    ```shell
    dotnet --list-sdks

    dotnet --version
    ```

1. Upload the package to your codespace in any folder.

1. Install the local package:

    ```shell
    dotnet tool install --add-source <path-to-folder-with-package> --global Demo.Tool.Speak
    ```

1. Test the tool:

    ```shell
    speak

    speak "<your-name>"
    ```
