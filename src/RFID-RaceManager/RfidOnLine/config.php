<?php
   class MyDB extends SQLite3
   {
      function __construct()
      {
         $this->open('races.sqlite');
      }
   }

   class ArrayUtils
   {
       public static function objArraySearch($array, $index, $value)
       {
           foreach($array as $arrayInf) {
               if($arrayInf[$index] == $value) {
                   return $arrayInf;
               }
           }
           return null;
       }
   }

   function seconds_from_time($time) 
   {
      $time = str_replace(',','.',$time);
      $array = explode(':', $time);
      if(count($array) > 3)
         list($d, $h, $m, $s) = explode(':', $time);
      else
      {
         $d = 0;
         list($h, $m, $s) = explode(':', $time);
      }
      return ($d * 86400) + ($h * 3600) + ($m * 60) + $s;
   }

   function do_sorting($a,$b) 
   {
       return ($a["AvgLapTimeSeconds"] <= $b["AvgLapTimeSeconds"]) ? -1 : 1;
   }
   
?>