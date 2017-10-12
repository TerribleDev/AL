type PackageType = Npm | Nuget | Maven

type IPackageProvider = 
    abstract member Name : string
    abstract member PackageType : PackageType

type NugetPackageProvider(name, packageType) = 
    interface IPackageProvider with
        member this.Name : string = name
        member this.PackageType = PackageType.Nuget

type NpmPackageProvider(name, packageType) = 
    interface IPackageProvider with
        member this.Name : string = name
        member this.PackageType = PackageType.Nuget
