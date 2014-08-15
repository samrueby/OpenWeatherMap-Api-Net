﻿// ***********************************************************************
// Assembly         : OpenWeatherMap
// Author           : Joan Caron
// Created          : 02-20-2014
// License          : MIT License (MIT) http://opensource.org/licenses/MIT
// Last Modified By : Joan Caron
// Last Modified On : 02-20-2014
// ***********************************************************************
// <copyright file="ForecastTime.cs" company="Joan Caron">
//     Copyright (c) Joan Caron. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Xml.Serialization;

namespace OpenWeatherMap {
	/// <summary>
	/// Class ForecastTime.
	/// </summary>
	public class ForecastTime {
		/// <summary>
		/// Gets or sets from.
		/// </summary>
		/// <value>From.</value>
		[ XmlAttribute( "from" ) ]
		public DateTime From { get; set; }

		/// <summary>
		/// Gets or sets to.
		/// </summary>
		/// <value>To.</value>
		[ XmlAttribute( "to" ) ]
		public DateTime To { get; set; }

		/// <summary>
		/// Gets or sets the day.
		/// </summary>
		/// <value>The day.</value>
		[ XmlAttribute( "day" ) ]
		public DateTime Day { get; set; }

		/// <summary>
		/// Gets or sets the symbol.
		/// </summary>
		/// <value>The symbol.</value>
		[ XmlElement( "symbol" ) ]
		public Symbol Symbol { get; set; }

		/// <summary>
		/// Gets or sets the precipitation.
		/// </summary>
		/// <value>The precipitation.</value>
		[ XmlElement( "precipitation" ) ]
		public ForecastPrecipitation Precipitation { get; set; }

		/// <summary>
		/// Gets or sets the wind direction.
		/// </summary>
		/// <value>The wind direction.</value>
		[ XmlElement( "windDirection" ) ]
		public WindDirection WindDirection { get; set; }

		/// <summary>
		/// Gets or sets the wind speed.
		/// </summary>
		/// <value>The wind speed.</value>
		[ XmlElement( "windSpeed" ) ]
		public WindSpeed WindSpeed { get; set; }

		/// <summary>
		/// Gets or sets the temperature.
		/// </summary>
		/// <value>The temperature.</value>
		[ XmlElement( "temperature" ) ]
		public Temperature Temperature { get; set; }

		/// <summary>
		/// Gets or sets the pressure.
		/// </summary>
		/// <value>The pressure.</value>
		[ XmlElement( "pressure" ) ]
		public Pressure Pressure { get; set; }

		/// <summary>
		/// Gets or sets the humidity.
		/// </summary>
		/// <value>The humidity.</value>
		[ XmlElement( "humidity" ) ]
		public Humidity Humidity { get; set; }

		/// <summary>
		/// Gets or sets the clouds.
		/// </summary>
		/// <value>The clouds.</value>
		[ XmlElement( "clouds" ) ]
		public ForecastClouds Clouds { get; set; }
	}
}
