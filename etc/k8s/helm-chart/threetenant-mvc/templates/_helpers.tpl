﻿{{- define "threetenant.global.env" -}}
- name: "App__WebSiteRootAddress"
  value: "{{ .Values.global.wwwUrl }}"
{{- end }}