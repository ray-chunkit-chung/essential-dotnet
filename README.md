# essential-dotnet


https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=Community&channel=Release&version=VS2022&source=VSLandingPage&passive=false&cid=2030#dotnet

<https://docs.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-code?pivots=dotnet-7-0>

https://dotnet.microsoft.com/en-us/learn/maui/first-app-tutorial/device-setup

## Step 1 Install .net sdk

```bash
wget https://packages.microsoft.com/config/debian/11/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
rm packages-microsoft-prod.deb
sudo apt-get update
sudo apt-get install -y dotnet-sdk-7.0
# sudo apt-get install -y dotnet-sdk-6.0
# sudo apt-get install -y dotnet-sdk-3.1
```


## Demo

```
.
├── HelloWorld
├── DotNetMaui
├── docs                    # Documentation files (alternatively `doc`)
│   ├── ...              # ...
│   └── ...                 # etc.
└── ...
```