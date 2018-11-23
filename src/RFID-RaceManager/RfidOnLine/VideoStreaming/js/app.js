var app = (function () {

	var start = function() {
		getPrice();
		$.ajaxSettings.cache = false;
		setInterval(getPrice, 1000);
	}
	
	var getPrice = function () {
	    $.getJSON("http://localhost:8090/race.json", function (data) {
	        $("title").text("Round " + data.Round + ", " + data.Group.Name);

	        $("#pilot1").text(data.Laps[0].PilotName);
	        $("#place1").text(data.Laps[0].CurrentPosition == null ? "--" : data.Laps[0].CurrentPosition);
	        $("#laps1").text(data.Laps[0].RegisteredLapsCount);
	        $("#bestLap1").text(data.Laps[0].BestLapTimeString == null ? "--" : data.Laps[0].BestLapTimeString);

	        $("#pilot2").text(data.Laps[1].PilotName);
	        $("#place2").text(data.Laps[1].CurrentPosition == null ? "--" : data.Laps[1].CurrentPosition);
	        $("#laps2").text(data.Laps[1].RegisteredLapsCount);
	        $("#bestLap2").text(data.Laps[1].BestLapTimeString == null ? "--" : data.Laps[1].BestLapTimeString);

	        $("#pilot3").text(data.Laps[2].PilotName);
	        $("#place3").text(data.Laps[2].CurrentPosition == null ? "--" : data.Laps[2].CurrentPosition);
	        $("#laps3").text(data.Laps[2].RegisteredLapsCount);
	        $("#bestLap3").text(data.Laps[2].BestLapTimeString == null ? "--" : data.Laps[2].BestLapTimeString);

	        $("#pilot4").text(data.Laps[3].PilotName);
	        $("#place4").text(data.Laps[3].CurrentPosition == null ? "--" : data.Laps[3].CurrentPosition);
	        $("#laps4").text(data.Laps[3].RegisteredLapsCount);
	        $("#bestLap4").text(data.Laps[3].BestLapTimeString == null ? "--" : data.Laps[3].BestLapTimeString);
	    });
	}

	return {
		start: start
	}		
})();

app.start();