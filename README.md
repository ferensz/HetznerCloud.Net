
# HetznerCloud.Net
.NET wrapper for the Hetzner Cloud API

HetznerCloud.Net is a .NET Standard 2.1 wrapper written for Hetzner Cloud management API. The goal of this project is to cover all of the functionalities what is provided by the HTTP API endpoint.

Currently implemented endpoints and functions:

:heavy_check_mark: - Available on API, implemented in wrapper\
:x: - Available on API, not implemented in wrapper yet\
:heavy_minus_sign: - Not available on API

|  | Get | Get all | Create | Update | Delete |
|--|:--:|:--:|:--:|:--:|:--:|
| Actions | :heavy_check_mark: | :heavy_check_mark: | :heavy_minus_sign: | :heavy_minus_sign: | :heavy_minus_sign: |
| Certificates | :heavy_check_mark: | :heavy_check_mark: | :x: | :x: | :heavy_check_mark: |
| Datacenters | :heavy_check_mark: | :heavy_check_mark: | :heavy_minus_sign: | :heavy_minus_sign: | :heavy_minus_sign: |
| Floating Ips | :heavy_check_mark: | :heavy_check_mark: | :x: | :x: | :heavy_check_mark: |
| Images | :heavy_check_mark: | :heavy_check_mark: | :heavy_minus_sign: | :x: | :heavy_check_mark: |
| ISOs | :heavy_check_mark: | :heavy_check_mark: | :heavy_minus_sign: | :heavy_minus_sign: | :heavy_minus_sign: |
| Load balancers | :heavy_check_mark: | :heavy_check_mark: | :x: | :x: | :heavy_check_mark: |
| Locations | :heavy_check_mark: | :heavy_check_mark: | :heavy_minus_sign: | :heavy_minus_sign: | :heavy_minus_sign: |
| Networks | :heavy_check_mark: | :heavy_check_mark: | :x: | :x: | :heavy_check_mark: |
| Pricing | :heavy_check_mark: | :heavy_minus_sign: | :heavy_minus_sign: | :heavy_minus_sign: | :heavy_minus_sign: |
| Servers | :heavy_check_mark: | :heavy_check_mark: | :x: | :x: | :heavy_check_mark: |
| Server types | :heavy_check_mark: | :heavy_check_mark: | :heavy_minus_sign: | :heavy_minus_sign: | :heavy_minus_sign: |
| SSH keys | :heavy_check_mark: | :heavy_check_mark: | :x: | :x: | :heavy_check_mark: |
| Volumes | :heavy_check_mark: | :heavy_check_mark: | :x: | :x: | :heavy_check_mark: |
