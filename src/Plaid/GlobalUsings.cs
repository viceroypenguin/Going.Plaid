global using System;
global using System.Collections.Generic;
global using System.Net;
global using System.Net.Http;
global using System.Net.Http.Json;
global using System.Runtime.Serialization;
global using System.Text.Json;
global using System.Text.Json.Serialization;
global using System.Threading.Tasks;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.Logging;
global using Microsoft.Extensions.Logging.Abstractions;
global using Microsoft.Extensions.Options;
global using Going.Plaid;
global using Going.Plaid.Entity;

#if !NET6_0_OR_GREATER

global using DateOnly = System.DateTime;

#endif
