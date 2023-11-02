using System.Collections.ObjectModel;
using System.IO;
using Itmo.ObjectOrientedProgramming.Lab2.Components;
using Newtonsoft.Json;

namespace Itmo.ObjectOrientedProgramming.Lab2.Stock;
public class ComponentsStock
{
    public ComponentsStock()
    {
        var settings = new JsonSerializerSettings
        {
            ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
        };

        string json = File.ReadAllText(@"C:\Users\kirbo\source\repos\krllbrsff\src\Lab2\Stock\CPUs.json");
        CPUStock = JsonConvert.DeserializeObject<Collection<CPU>>(json, settings);

        json = File.ReadAllText(@"C:\Users\kirbo\source\repos\krllbrsff\src\Lab2\Stock\GPUs.json");
        GPUStock = JsonConvert.DeserializeObject<Collection<GPU>>(json, settings);

        json = File.ReadAllText(@"C:\Users\kirbo\source\repos\krllbrsff\src\Lab2\Stock\Motherboards.json");
        MotherboardStock = JsonConvert.DeserializeObject<Collection<Motherboard>>(json, settings);

        json = File.ReadAllText(@"C:\Users\kirbo\source\repos\krllbrsff\src\Lab2\Stock\RAMs.json");
        RAMStock = JsonConvert.DeserializeObject<Collection<RAM>>(json, settings);

        json = File.ReadAllText(@"C:\Users\kirbo\source\repos\krllbrsff\src\Lab2\Stock\SSDs.json");
        SSDStock = JsonConvert.DeserializeObject<Collection<SSD>>(json, settings);

        json = File.ReadAllText(@"C:\Users\kirbo\source\repos\krllbrsff\src\Lab2\Stock\HDDs.json");
        HDDStock = JsonConvert.DeserializeObject<Collection<HDD>>(json, settings);

        json = File.ReadAllText(@"C:\Users\kirbo\source\repos\krllbrsff\src\Lab2\Stock\Corpuses.json");
        CorpusStock = JsonConvert.DeserializeObject<Collection<Corpus>>(json, settings);

        json = File.ReadAllText(@"C:\Users\kirbo\source\repos\krllbrsff\src\Lab2\Stock\WiFiAdapters.json");
        WiFiAdapterStock = JsonConvert.DeserializeObject<Collection<WiFiAdapter>>(json, settings);

        json = File.ReadAllText(@"C:\Users\kirbo\source\repos\krllbrsff\src\Lab2\Stock\CPUCoolers.json");
        CoolerStock = JsonConvert.DeserializeObject<Collection<CPUCooler>>(json, settings);

        json = File.ReadAllText(@"C:\Users\kirbo\source\repos\krllbrsff\src\Lab2\Stock\PowerSupplies.json");
        PowerSupplyStock = JsonConvert.DeserializeObject<Collection<PowerSupply>>(json, settings);
    }

    public Collection<CPU>? CPUStock { get; private set; }
    public Collection<GPU>? GPUStock { get; private set; }
    public Collection<CPUCooler>? CoolerStock { get; private set; }
    public Collection<Motherboard>? MotherboardStock { get; private set; }
    public Collection<SSD>? SSDStock { get; private set; }
    public Collection<HDD>? HDDStock { get; private set; }
    public Collection<PowerSupply>? PowerSupplyStock { get; private set; }
    public Collection<RAM>? RAMStock { get; private set; }
    public Collection<WiFiAdapter>? WiFiAdapterStock { get; private set; }
    public Collection<Corpus>? CorpusStock { get; private set; }

    public void Add(CPU item)
    {
        CPUStock?.Add(item);
        string json = JsonConvert.SerializeObject(CPUStock);
        File.WriteAllText(@"C:\Users\kirbo\source\repos\krllbrsff\src\Lab2\Stock\CPUs.json", json);
    }

    public void Add(GPU item)
    {
        GPUStock?.Add(item);
        string json = JsonConvert.SerializeObject(GPUStock);
        File.WriteAllText(@"C:\Users\kirbo\source\repos\krllbrsff\src\Lab2\Stock\GPUs.json", json);
    }

    public void Add(RAM item)
    {
        RAMStock?.Add(item);
        string json = JsonConvert.SerializeObject(RAMStock);
        File.WriteAllText(@"C:\Users\kirbo\source\repos\krllbrsff\src\Lab2\Stock\GPUs.json", json);
    }

    public void Add(SSD item)
    {
        SSDStock?.Add(item);
        string json = JsonConvert.SerializeObject(SSDStock);
        File.WriteAllText(@"C:\Users\kirbo\source\repos\krllbrsff\src\Lab2\Stock\SSDs.json", json);
    }

    public void Add(HDD item)
    {
        HDDStock?.Add(item);
        string json = JsonConvert.SerializeObject(HDDStock);
        File.WriteAllText(@"C:\Users\kirbo\source\repos\krllbrsff\src\Lab2\Stock\HDDs.json", json);
    }

    public void Add(CPUCooler item)
    {
        CoolerStock?.Add(item);
        string json = JsonConvert.SerializeObject(CoolerStock);
        File.WriteAllText(@"C:\Users\kirbo\source\repos\krllbrsff\src\Lab2\Stock\CPUCoolers.json", json);
    }

    public void Add(Corpus item)
    {
        CorpusStock?.Add(item);
        string json = JsonConvert.SerializeObject(CorpusStock);
        File.WriteAllText(@"C:\Users\kirbo\source\repos\krllbrsff\src\Lab2\Stock\Corpuses.json", json);
    }

    public void Add(WiFiAdapter item)
    {
        WiFiAdapterStock?.Add(item);
        string json = JsonConvert.SerializeObject(WiFiAdapterStock);
        File.WriteAllText(@"C:\Users\kirbo\source\repos\krllbrsff\src\Lab2\Stock\WiFiAdapters.json", json);
    }

    public void Add(Motherboard item)
    {
        MotherboardStock?.Add(item);
        string json = JsonConvert.SerializeObject(MotherboardStock);
        File.WriteAllText(@"C:\Users\kirbo\source\repos\krllbrsff\src\Lab2\Stock\Motherboards.json", json);
    }

    public void Add(PowerSupply item)
    {
        PowerSupplyStock?.Add(item);
        string json = JsonConvert.SerializeObject(PowerSupplyStock);
        File.WriteAllText(@"C:\Users\kirbo\source\repos\krllbrsff\src\Lab2\Stock\PowerSupplies.json", json);
    }

    public void Remove(CPU item)
    {
        CPUStock?.Remove(item);
        string json = JsonConvert.SerializeObject(CPUStock);
        File.WriteAllText(@"C:\Users\kirbo\source\repos\krllbrsff\src\Lab2\Stock\CPUs.json", json);
    }

    public void Remove(GPU item)
    {
        GPUStock?.Remove(item);
        string json = JsonConvert.SerializeObject(GPUStock);
        File.WriteAllText(@"C:\Users\kirbo\source\repos\krllbrsff\src\Lab2\Stock\GPUs.json", json);
    }

    public void Remove(SSD item)
    {
        SSDStock?.Remove(item);
        string json = JsonConvert.SerializeObject(SSDStock);
        File.WriteAllText(@"C:\Users\kirbo\source\repos\krllbrsff\src\Lab2\Stock\SSDs.json", json);
    }

    public void Remove(HDD item)
    {
        HDDStock?.Remove(item);
        string json = JsonConvert.SerializeObject(HDDStock);
        File.WriteAllText(@"C:\Users\kirbo\source\repos\krllbrsff\src\Lab2\Stock\HDDs.json", json);
    }

    public void Remove(CPUCooler item)
    {
        CoolerStock?.Remove(item);
        string json = JsonConvert.SerializeObject(CoolerStock);
        File.WriteAllText(@"C:\Users\kirbo\source\repos\krllbrsff\src\Lab2\Stock\CPUCoolers.json", json);
    }

    public void Remove(Corpus item)
    {
        CorpusStock?.Remove(item);
        string json = JsonConvert.SerializeObject(CorpusStock);
        File.WriteAllText(@"C:\Users\kirbo\source\repos\krllbrsff\src\Lab2\Stock\Corpuses.json", json);
    }

    public void Remove(WiFiAdapter item)
    {
        WiFiAdapterStock?.Remove(item);
        string json = JsonConvert.SerializeObject(WiFiAdapterStock);
        File.WriteAllText(@"C:\Users\kirbo\source\repos\krllbrsff\src\Lab2\Stock\WiFiAdapters.json", json);
    }

    public void Remove(Motherboard item)
    {
        MotherboardStock?.Remove(item);
        string json = JsonConvert.SerializeObject(MotherboardStock);
        File.WriteAllText(@"C:\Users\kirbo\source\repos\krllbrsff\src\Lab2\Stock\Motherboards.json", json);
    }

    public void Remove(PowerSupply item)
    {
        PowerSupplyStock?.Remove(item);
        string json = JsonConvert.SerializeObject(PowerSupplyStock);
        File.WriteAllText(@"C:\Users\kirbo\source\repos\krllbrsff\src\Lab2\Stock\PowerSupplies.json", json);
    }
}
