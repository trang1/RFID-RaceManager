<?php
   include 'config.php';
   $db = new MyDB();
   	$round = 'best';
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
		  		
			      	<li class="nav-item active">
			        	<a class="nav-link" href="ranking.php">CLASSIFICAÇÃO GERAL</a>
			      	</li>
			     
			      	
		  		</ul>
		  	</div>
	  	</div>
	</nav>
    <div class="container mt-4">
    	<h5 class="mb-4 title"><strong>Classificação</strong> Geral</h5>
    	<div class="navigations sticky-top">
    		<ul class="nav nav-pills mb-4">
    			
				<li class="nav-item">
					<a class="nav-link <?= ($round=='avg') ? 'active' : '' ?>" href="?q=avg">
						Classificação Media TOP 3 
					</a>
				</li>
    		</ul>
    	</div>
    	<?php
    		if($round == 'best')
    		{
		?>
		
		
		<?php  			
    		} else if($round == 'avg'){
    	?>
    		<?php
		    	$db = new MyDB();
		    	
		    	$result = $db->query("SELECT l.* from LapsInfos l join RaceEvents re on re.Id = l.RaceEventId where re.Name in ('Q1','Q2','Q3','Q4')");

		    	$avgSource = array();
		    	$i=0;
		    	while($row = $result->fetchArray(SQLITE3_ASSOC) ){
		    		$row["AvgLapTimeSeconds"] = seconds_from_time($row["AvgLapTime"]);
					$existingLap = ArrayUtils::objArraySearch($avgSource,'Epc',$row["Epc"]);
					if($existingLap == null){
						$avgSource[] = $row;
					} else {
						if($existingLap["AvgLapTime"].time() > $row["AvgLapTime"].time())
							$avgSource[array_search($existingLap, $avgSource)] = $row;
					}
					$i++;
			   	}
			   	usort($avgSource, "do_sorting");
			?>
    		<table class="table table-bordered table-sm table-hover">
				<thead>
					<tr>
						<th scope="col">#</th>
						<th scope="col">Piloto</th>
						<th scope="col">Media TOP 3</th>
					</tr>
				</thead>
				<tbody>
					<?php
						$k=1;
				    	foreach($avgSource as $avg) {
					?>
						<tr>
							<td><?= $k ?></td>
							<td><strong><?= $avg["PilotName"] ?></strong></td>
							<td><?= $avg["AvgLapTime"] ?></td>
						</tr>
					<?php
						$k++;
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
