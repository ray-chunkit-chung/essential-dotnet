# essential-dotnet

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

.
├── HelloWorld
├── ...
├── docs                    # Documentation files (alternatively `doc`)
│   ├── ...              # ...
│   └── ...                 # etc.
└── ...