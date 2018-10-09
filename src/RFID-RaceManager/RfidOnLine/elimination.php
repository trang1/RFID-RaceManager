<?php
   	include 'config.php';
   	$db = new MyDB();
   	$round = 'R';
   	if(isset($_GET['q'])){
   		$round = $_GET['q'];
   	}
?>
<!doctype html>
<html lang="en">
  <head>
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <link href="https://fonts.googleapis.com/css?family=Lato:300,400,700" rel="stylesheet">
    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
    <link rel="stylesheet" href="css/style.css"/>
    <title>SDR 2018 Live</title>
  </head>
  <body>
  	<nav class="navbar navbar-expand-lg navbar-light bg-light">
  		<div class="container">
	  		<a class="navbar-brand mb-0 h1" href="index.php"><img src="images/logo.png" width="40" /> Gestão SDR 2018</a>
	  		<button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav" aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
		    	<span class="navbar-toggler-icon"></span>
		  	</button>
		  	<div class="collapse navbar-collapse" id="navbarNav">
		  		<ul class="navbar-nav">
		  			<li class="nav-item">
			        	<a class="nav-link" href="index.php">LISTA DE PILOTOS <span class="sr-only">(current)</span></a>
			      	</li>
			      	<li class="nav-item">
			        	<a class="nav-link" href="groups.php">GRUPOS</a>
			      	</li>
			      	<li class="nav-item">
			        	<a class="nav-link" href="qualification.php">QUALIFICAÇÃO</a>
			      	</li>
			      	<li class="nav-item active">
			        	<a class="nav-link" href="elimination.php">ELIMINATÓRIAS</a>
			      	</li>
			      	<li class="nav-item">
			        	<a class="nav-link" href="ranking.php">CLASSIFICAÇÃO GERAL</a>
			      	</li>
			      	<li class="nav-item">
			        	<a class="nav-link" href="youtube.php">LIVE STREAMING</a>
			      	</li>
			      	</ul>
		  	</div>
	  	</div>
	</nav>
    <div class="container mt-4">
    	<h5 class="mb-4 title"><strong>ELIMINATÓRIAS</strong></h5>
    	<div class="navigations sticky-top">
	    	<ul class="nav nav-pills nav-fill mb-4">
	    		<?php
	    	
			    	$rounds = $db->query("SELECT distinct re.Name FROM RaceEvents re where re.Name in ('R','S','F')");
			    
			    	while($r = $rounds->fetchArray(SQLITE3_ASSOC) ){
			    ?>
			    	<li class="nav-item">
						<a class="nav-link <?= ($round==$r["Name"]) ? 'active' : '' ?>" href="?q=<?= $r["Name"] ?>"><?= $r["Name"] ?>
						</a>
					</li>
			    <?php
		    		}
			    ?>
			</ul>
		</div>
		<?php
	    	
	    	$result = $db->query("SELECT distinct G.*,count(re.Id) FROM Groups G inner join RaceEvents re on re.group_id = G.Id WHERE re.Name='".$round."' group by G.Id, G.Name");
	    
	    	while($row = $result->fetchArray(SQLITE3_ASSOC) ){
	    ?>
	    	<h6 class="text-uppercase"><?= $row["Name"] ?></h6>
	    	<table class="table table-bordered table-sm table-hover">
				<thead>
					<tr>
						<th scope="col">Pilot Id</th>
						<th scope="col">Pilot Name</th>
						<th scope="col">Lap1</th>
						<th scope="col">Lap2</th>
						<th scope="col">Lap3</th>
						<th scope="col">Best Lap Time</th>
						<th scope="col">Avg Lap Time</th>
					</tr>
				</thead>
				<tbody>
					<?php
				    	
				    	$lapinfo = $db->query("SELECT L.*,re.Name FROM LapsInfos L INNER JOIN RaceEvents re on L.RaceEventId = re.Id inner join Races r on r.id = re.raceid inner join groups g on g.id = re.group_id join pilots p on p.id = l.pilotid WHERE re.Name='".$round."' AND g.Id = ".$row["Id"]);
				    	while($lap = $lapinfo->fetchArray(SQLITE3_ASSOC) ){
				    		
				    ?>
				    	<tr>
				    		<td><?= $lap["PilotId"] ?></td>
				    		<td><strong><?= $lap["PilotName"] ?></strong></td>
				    		<td><?= $lap["Lap1"] ?></td>
				    		<td><?= $lap["Lap2"] ?></td>
				    		<td><?= $lap["Lap3"] ?></td>
				    		<td><?= $lap["BestLapTime"] ?></td>
				    		<td><?= $lap["AvgLapTime"] ?></td>
				    	</tr>
				    <?php
				    	}
					?>
				</tbody>
			</table>
	    <?php
	    	}
	    ?>
    </div>

    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
   <center>CHRONOSYSTEM | RC-Works | 3D Works | DSB</center>
  </body>
</html>
