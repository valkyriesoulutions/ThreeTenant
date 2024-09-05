Install using;

```bash
helm upgrade --install anz threetenant-mvc
```

Uninstall all charts

```bash
helm uninstall anz
```

## Create Images

```bash
docker build -t threetenant-mvc -f src\ThreeTenant.Web.Mvc\Dockerfile .
docker build -t threetenant-migrator -f src\ThreeTenant.Migrator\Dockerfile .
```
