Install using;

```bash
helm upgrade --install anz threetenant-angular
```

Uninstall all charts

```bash
helm uninstall anz
```

## Create Images

### run in the aspnet-core folder
```bash
docker build -t threetenant-host -f src\ThreeTenant.Web.Host\Dockerfile .
docker build -t threetenant-migrator -f src\ThreeTenant.Migrator\Dockerfile .
```

### run in the angular folder
```bash
docker build -t threetenant-angular -f Dockerfile . 
```
