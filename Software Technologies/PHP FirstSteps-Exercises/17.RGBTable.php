<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>RGB Table</title>
    <style>
        table * {
            border: 1px solid black;
            width: 50px;
            height: 50px;
        }
    </style>
</head>
<body>
<table>
    <tr>
        <td>
            Red
        </td>
        <td>
            Green
        </td>
        <td>
            Blue
        </td>
    </tr>
    <?php
    $red=intval(51);
    $blue=intval(51);
    $green=intval(51);
    for ($i = 1; $i <= 5; $i++) {
        ?>
        <tr>
            <?php
            for ($j = 1; $j <= 3; $j++) {

                if ( $j==1){?>
                    <td style="background-color:rgb(<?=$red?>,0,0)"></td>
               <?php }else if ($j==2){ ?>
                    <td style="background-color:rgb(0,<?=$green?>,0)"></td>
               <?php }else{?>
                    <td style="background-color:rgb(0,0,<?=$blue?>)"></td>
               <?php }
            }?>
        </tr>
        <?php
        $red= $red + 51;
        $green= $green + 51;
        $blue= $blue + 51;
    }
    ?>
</table>
</body>
</html>