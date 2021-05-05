using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Going.Plaid.Entity
{
	/// <summary>
	/// Represents a banking institution.
	/// </summary>
	public class Institution
	{
		/// <summary>
		/// Unique identifier for the institution.
		/// </summary>
		[JsonPropertyName("institution_id")]
		public string InstitutionId { get; init; } = null!;

		/// <summary>
		/// The official name of the institution.
		/// </summary>
		[JsonPropertyName("name")]
		public string Name { get; init; } = null!;

		/// <summary>
		/// A list of the Plaid products supported by the institution.
		/// </summary>
		[JsonPropertyName("products")]
		public Product[] Products { get; init; } = null!;

		/// <summary>
		/// A list of country codes associated with the institution.
		/// </summary>
		[JsonPropertyName("country_codes")]
		public string[] CountryCodes { get; init; } = null!;

		/// <summary>
		/// Indicates if this institution uses OAuth flows
		/// </summary>
		[JsonPropertyName("oauth")]
		public bool? OAuth { get; init; }

		/// <summary>
		/// The total number of institutions available via this endpoint
		/// </summary>
		[JsonPropertyName("total")]
		public int Total { get; init; }

		#region Optional Metadata: include_optional_metadata

		/// <summary>
		/// A list of routing numbers associated with the institution.
		/// </summary>
		[JsonPropertyName("routing_numbers")]
		public string[]? RoutingNumbers { get; init; }

		/// <summary>
		/// The URL for the institution's website.
		/// </summary>
		[JsonPropertyName("url")]
		public string? Url { get; init; }

		/// <summary>
		/// The primary colour for the institution to use in visual displays.
		/// The Brand color is in hexadecimal format
		/// </summary>
		[JsonPropertyName("primary_color")]
		public string? PrimaryColor { get; init; }

		/// <summary>
		/// The logo for the institution to use in visual displays.
		/// When available, the bank's logo is returned as a base64 encoded 152x152 PNG
		/// </summary>
		[JsonPropertyName("logo")]
		public string? Logo { get; init; }

		#endregion

		#region Optional Metadata: include_status

		/// <summary>
		/// The status of an institution is determined by the health of its Item logins, Transactions updates, Investments updates, Auth requests, Balance requests, and Identity requests. A login attempt is conducted during the initial Item add in Link. If there is not enough traffic to accurately calculate an institution's status, Plaid will return <c>null</c> rather than potentially inaccurate data.
		/// </summary>
		[JsonPropertyName("status")]
		public InstitutionStatusData? InstitutionStatus { get; init; }

		/// <summary>
		/// The status of an institution is determined by the health of its Item logins, Transactions updates, Investments updates, Auth requests, Balance requests, and Identity requests. A login attempt is conducted during the initial Item add in Link. If there is not enough traffic to accurately calculate an institution's status, Plaid will return <c>null</c> rather than potentially inaccurate data.
		/// </summary>
		public class InstitutionStatusData
		{
			/// <summary>
			/// Details of the status health of item logins
			/// </summary>
			[JsonPropertyName("item_logins")]
			public ItemStatusDetails? ItemLogins { get; init; }

			/// <summary>
			/// Details of the status health of transaction updates
			/// </summary>
			[JsonPropertyName("transactions_updates")]
			public ItemStatusDetails? TransactionsUpdates { get; init; }

			/// <summary>
			/// Details of the status health of auth requests
			/// </summary>
			[JsonPropertyName("auth")]
			public ItemStatusDetails? Auth { get; init; }

			/// <summary>
			/// Details of the status health of balance requests
			/// </summary>
			[JsonPropertyName("balance")]
			public ItemStatusDetails? Balance { get; init; }

			/// <summary>
			/// Details of the status health of identity requests
			/// </summary>
			[JsonPropertyName("identity")]
			public ItemStatusDetails? Identity { get; init; }

			/// <summary>
			/// Details of the status health of investments updates
			/// </summary>
			[JsonPropertyName("investments_updates")]
			public ItemStatusDetails? InvestmentsUpdates { get; init; }

			/// <summary>
			/// Details of recent health incidents associated with the institution.
			/// </summary>
			[JsonPropertyName("health_incidents")]
			public HealthIncidentDetails[]? HealthIncidents { get; init; }
		}

		/// <summary>
		/// A representation of the status health of a request type. Auth requests, Balance requests, Identity requests, Transactions updates, Investments updates, and Item logins each have their own status object.
		/// </summary>
		public class ItemStatusDetails
		{
			/// <summary>
			/// Overall Item Status
			/// </summary>
			[JsonPropertyName("status")]
			public ItemStatus Status { get; init; }

			/// <summary>
			/// Timestamp of the last status change for the institution
			/// </summary>
			[JsonPropertyName("last_status_change")]
			public DateTimeOffset LastStatusChange { get; init; }

			/// <summary>
			/// A detailed breakdown of the institution's performance for a request type.
			/// </summary>
			[JsonPropertyName("breakdown")]
			public ItemStatusBreakdown? Breakdown { get; init; }
		}

		/// <summary>
		/// Overall Item Status
		/// </summary>
		public enum ItemStatus
		{
			/// <summary>
			/// The majority of requests are successful
			/// </summary>
			[EnumMember(Value = "HEALTHY")]
			Healthy,

			/// <summary>
			/// Only some requests are successful
			/// </summary>
			[EnumMember(Value = "DEGRADED")]
			Degraded,

			/// <summary>
			/// All requests are failing
			/// </summary>
			[EnumMember(Value = "DOWN")]
			Down,
		}

		/// <summary>
		/// A detailed breakdown of the institution's performance for a request type. The values for <see cref="Success"/>, <see cref="ErrorPlaid"/>, and <see cref="ErrorInstitution"/> sum to 1.
		/// </summary>
		public class ItemStatusBreakdown
		{
			/// <summary>
			/// The percentage of login attempts that are successful.
			/// </summary>
			[JsonPropertyName("success")]
			public decimal Success { get; init; }

			/// <summary>
			/// The percentage of logins that are failing due to an internal Plaid issue.
			/// </summary>
			[JsonPropertyName("error_plaid")]
			public decimal ErrorPlaid { get; init; }

			/// <summary>
			/// The percentage of logins that are failing due to an issue in the institution's system, expressed as a decimal.
			/// </summary>
			[JsonPropertyName("error_institution")]
			public decimal ErrorInstitution { get; init; }

			/// <summary>
			/// How often the status is being updated
			/// </summary>
			/// <remarks>
			/// This value is only returned for <see cref="InstitutionStatusData.TransactionsUpdates"/> status breakdowns.
			/// </remarks>
			public RefreshIntervalStatus? RefreshInterval { get; init; }

			/// <summary>
			/// How often the status is being updated
			/// </summary>
			public enum RefreshIntervalStatus
			{
				/// <summary>
				/// Status is being update normally.
				/// </summary>
				[EnumMember(Value = "NORMAL")]
				Normal,

				/// <summary>
				/// Status updates have been delayed.
				/// </summary>
				[EnumMember(Value = "DELAYED")]
				Delayed,

				/// <summary>
				/// Status updates have been stopped.
				/// </summary>
				[EnumMember(Value = "STOPPED")]
				Stopped,
			}
		}

		/// <summary>
		/// Details of a recent health incident associated with the institution.
		/// </summary>
		public class HealthIncidentDetails
		{
			/// <summary>
			/// The start date of the incident
			/// </summary>
			[JsonPropertyName("start_date")]
			public DateTimeOffset StartDate { get; init; }

			/// <summary>
			/// The end date of the incident
			/// </summary>
			[JsonPropertyName("end_date")]
			public DateTimeOffset EndDate { get; init; }

			/// <summary>
			/// The title of the incident
			/// </summary>
			[JsonPropertyName("title")]
			public string Title { get; init; } = null!;

			/// <summary>
			/// Updates on the health incident.
			/// </summary>
			[JsonPropertyName("incident_updates")]
			public HealthIncidentUpdate[]? IncidentUpdates { get; init; }
		}

		/// <summary>
		/// An update to a health incident.
		/// </summary>
		public class HealthIncidentUpdate
		{
			/// <summary>
			/// The content of the update.
			/// </summary>
			[JsonPropertyName("description")]
			public string Description { get; init; } = null!;

			/// <summary>
			/// The status of the incident.
			/// </summary>
			[JsonPropertyName("status")]
			public HealthIncidentUpdateStatus Status { get; init; }

			/// <summary>
			/// The date when the update was published.
			/// </summary>
			[JsonPropertyName("updated_date")]
			public DateTimeOffset UpdatedDate { get; init; }

			/// <summary>
			/// The status of the incident.
			/// </summary>
			public enum HealthIncidentUpdateStatus
			{
				/// <summary>
				/// This incident is currently under investigation
				/// </summary>
				[EnumMember(Value = "INVESTIGATING")]
				Investigating,

				/// <summary>
				/// The problem has been identified
				/// </summary>
				[EnumMember(Value = "IDENTIFIED")]
				Identified,

				/// <summary>
				/// The problem has been resolved
				/// </summary>
				[EnumMember(Value = "RESOLVED")]
				Resolved,

				/// <summary>
				/// The problem resolution has been scheduled
				/// </summary>
				[EnumMember(Value = "SCHEDULED")]
				Scheduled,

				/// <summary>
				/// The current status is unknown
				/// </summary>
				[EnumMember(Value = "UNKNOWN")]
				Unknown,
			}
		}

		#endregion

		#region Optional Metadata: include_payment_initiation_metadata

		/// <summary>
		/// Metadata that captures what specific payment configurations an institution supports when making Payment Initiation requests.
		/// </summary>
		[JsonPropertyName("payment_initiation_metadata")]
		public PaymentInitiationMetadataData? PaymentInitiationMetadata { get; init; }

		/// <summary>
		/// Metadata that captures what specific payment configurations an institution supports when making Payment Initiation requests.
		/// </summary>
		public class PaymentInitiationMetadataData
		{
			/// <summary>
			/// Indicates whether the institution supports payments from a different country.
			/// </summary>
			[JsonPropertyName("supports_international_payments")]
			public bool SupportsInternationalPayments { get; init; }

			/// <summary>
			/// A mapping of currency to maximum payment amount (denominated in the smallest unit of currency) supported by the insitution.
			/// </summary>
			/// <example><c>["GBP"] = 10000</c></example>
			[JsonPropertyName("maximum_payment_amount")]
			public IReadOnlyDictionary<string, decimal> MaximumPaymentAmount { get; init; } = new Dictionary<string, decimal>();

			/// <summary>
			/// Indicates whether the institution supports returning refund details when initiating a payment.
			/// </summary>
			[JsonPropertyName("supports_refund_details")]
			public bool SupportsRefundDetails { get; init; }

			/// <summary>
			/// Metadata specifically related to valid Payment Initiation standing order configurations for the institution.
			/// </summary>
			public StandingOrderMetadata? StandingOrderMetadata { get; init; }
		}

		/// <summary>
		/// Metadata specifically related to valid Payment Initiation standing order configurations for the institution.
		/// </summary>
		public class StandingOrderMetadata
		{
			/// <summary>
			/// Indicates whether the institution supports closed-ended standing orders by providing an end date.
			/// </summary>
			[JsonPropertyName("supports_standing_order_end_date")]
			public bool SupportsStandingOrderEndDate { get; init; }

			/// <summary>
			/// This is only applicable to MONTHLY standing orders. Indicates whether the institution supports negative integers (-1 to -5) for setting up a MONTHLY standing order relative to the end of the month.
			/// </summary>
			[JsonPropertyName("supports_standing_order_negative_execution_days")]
			public bool SupportsStandingOrderNegativeExecutionDays { get; init; }

			/// <summary>
			/// A list of the valid standing order intervals supported by the institution.
			/// </summary>
			[JsonPropertyName("valid_standing_order_intervals")]
			public Intervals[] ValidStandingOrderIntervals { get; init; } = Array.Empty<Intervals>();

			/// <summary>
			/// Time Intervals
			/// </summary>
			public enum Intervals
			{
				/// <summary>
				/// Weekly Interval
				/// </summary>
				[EnumMember(Value = "WEEKLY")]
				Weekly,

				/// <summary>
				/// Montly Interval
				/// </summary>
				[EnumMember(Value = "MONTHLY")]
				Monthly,
			}
		}

		#endregion

	}
}
