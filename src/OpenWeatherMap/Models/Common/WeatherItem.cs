﻿// ***********************************************************************
// Assembly         : OpenWeatherMap
// Author           : Joan Caron
// Created          : 02-20-2014
// License          : MIT License (MIT) http://opensource.org/licenses/MIT
// Last Modified By : Joan Caron
// Last Modified On : 02-20-2014
// ***********************************************************************
// <copyright file="WeatherItem.cs" company="Joan Caron">
//     Copyright (c) Joan Caron. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Xml.Serialization;

namespace OpenWeatherMap {
	/// <summary>
	/// Class WeatherItem.
	/// </summary>
	public class WeatherItem {
		/// <summary>
		/// Gets or sets the city.
		/// </summary>
		/// <value>The city.</value>
		[ XmlElement( "city" ) ]
		public City City { get; set; }

		/// <summary>
		/// Gets or sets the temperature.
		/// </summary>
		/// <value>The temperature.</value>
		[ XmlElement( "temperature" ) ]
		public Temperature Temperature { get; set; }

		/// <summary>
		/// Gets or sets the humidity.
		/// </summary>
		/// <value>The humidity.</value>
		[ XmlElement( "humidity" ) ]
		public Humidity Humidity { get; set; }

		/// <summary>
		/// Gets or sets the pressure.
		/// </summary>
		/// <value>The pressure.</value>
		[ XmlElement( "pressure" ) ]
		public Pressure Pressure { get; set; }

		/// <summary>
		/// Gets or sets the wind.
		/// </summary>
		/// <value>The wind.</value>
		[ XmlElement( "wind" ) ]
		public Wind Wind { get; set; }

		/// <summary>
		/// Gets or sets the clouds.
		/// </summary>
		/// <value>The clouds.</value>
		[ XmlElement( "clouds" ) ]
		public Clouds Clouds { get; set; }

		/// <summary>
		/// Gets or sets the precipitation.
		/// </summary>
		/// <value>The precipitation.</value>
		[ XmlElement( "precipitation" ) ]
		public Precipitation Precipitation { get; set; }

		/// <summary>
		/// Gets or sets the weather.
		/// </summary>
		/// <value>The weather.</value>
		[ XmlElement( "weather" ) ]
		public Weather Weather { get; set; }

		/// <summary>
		/// Gets or sets the last update.
		/// </summary>
		/// <value>The last update.</value>
		[ XmlElement( "lastupdate" ) ]
		public LastUpdate LastUpdate { get; set; }
	}
}
