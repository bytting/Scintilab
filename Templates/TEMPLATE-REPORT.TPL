$REM
$REM Sample Information Report Template
$REM
$SEC Header
$REM ----1---------2---------3---------4----------5---------6---------7
"*************************************************************************"
"*****        G A M M A   S P E C T R U M    A N A L Y S I S         *****"
"*************************************************************************"
""
""
$DEFL STITLE SIDENT STYPE SGEOMTRY SQUANT SUNITS STIME SDESC1 SDESC4 SCOLLNAME
$GETL 1 1 0
"Filename: |AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" #filename
""
"Report Generated On             : |DDDDDDDDD |TTTTTTTTTT" #datetime #datetime
"Measurement started by          : |AAAAAAAAAAAAAAA" #LIS1(10) 
""
"Spectrum no                     : |AAAAAAAA" #LIS1(9)
""
"Sample Order                    : |AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" #LIS1(1)
""
"Sample Identification           : |AAAAAAAAAAAAAAA" #LIS1(2)
"Sample Type                     : |AAAAAAAAAAAAAAA" #LIS1(3)
"Sample Geometry                 : |AAAAAAAAAAAAAAA" #LIS1(4)
""
"Sample Description              : |AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" #LIS1(8)
""
$IFEQSI SLOCTN '' 
$ELSE
"Sample Location                 : |AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" SLOCTN
$ENDIF
""
"Peak Locate Threshold           : |F.FF" SENSITVTY
"Peak Locate Range (in channels) : |IIII - |IIII" PEAKSTART PEAKEND
"Peak Area Range (in channels)   : |IIII - |IIII" PASTART PAEND
$IF USEVARETOL
$SETE #FV1 VARTOLERANCE
"Identification Energy Tolerance : |FFF.FFF FWHM" #FV1
$ENDIF
$IFNOT USEVARETOL
$SETE #FV1 TOLERANCE
$SETD #FV1 ECALCNV
"Identification Energy Tolerance : |FFF.FFF |AA" #FV1 ECALUNITS
$ENDIF
""
"Sample Size                     : |EEEEEEEEEE |AAAAAAA" #LIS1(5) #LIS1(6)
""
"Sample Taken On                 : |DDDDDDDDD |TTTTTTTTTT" #LIS1(7) #LIS1(7)
"Acquisition Started             : |DDDDDDDDD |TTTTTTTTTT" ASTIME ASTIME
""
"Live Time                       : |FFFFFFF.F seconds" ELIVE
"Real Time                       : |FFFFFFF.F seconds" EREAL
""
$SETE #FV1 ELIVE
$SETE #FV2 EREAL
$SETS #FV2 #FV1
$SETM #FV2 100
$SETD #FV2 EREAL
"Dead Time                       : |FF.FF %" #FV2
""
""
"              Energy Calibration Used Done On       : |DDDDDDDDD" ECALTIME
"              Efficiency Calibration Used Done On   : |DDDDDDDDD" DCALTIME
"              Efficiency ID                         : |AAAAAAAAAAAAAAAAAAAAAA" GEOMETRY
""
$SEC BackgrSub
$PH "Background Subtract Report             |DDDDDDDDD |TTTTTTTTTT      Page |I" #datetime #datetime #pagenum
$NP 57
$SETE #IV1 0
$IF PSFENBACK
$SETE #IV1 1
$ENDIF
$IF PSFREAGENT
$SETE #IV1 1
$ENDIF
$IF #IV1
$IF RECCNT(PSCENTRD)
$REM ----1---------2---------3---------4---------5---------6---------7---------
"**************************************************************************"
"*****        B A C K G R O U N D  S U B T R A C T  R E P O R T       *****"
"**************************************************************************"
""
$DEFL DETNAME STITLE PSDATE
$GETL 1 1 0
$REM "     Detector Name:  |AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" #LIS1(1)
$REM "     Sample Title:   |AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" #LIS1(2)
$REM "     Peak Analysis Performed on:  |DDDDDDDDD |TTTTTTTTTT" #LIS1(3) #LIS1(3)
""
$IF PSFENBACK
  $IF PRUSESTRDBKG
"Env. Background File:     Using Stored Background Information."
"Orig Background File:     |AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" EXPBACK
  $ELSE
"Env. Background File:     |AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" EXPBACK
$ENDIF
$ENDIF
$IF PSFREAGENT
  $IF PRUSESTRDBKG
"     Reagent Blank File:        Using Stored Background Information."
  $ELSE
"     Reagent Blank File:       |AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" REAGENTFILE
  $ENDIF
$ENDIF
""
" Peak  Energy  Original Orig. Area  Ambient    Backgr.  Subtracted  Subtracted"
"   No. (keV)     Area     Uncert.  Background  Uncert.     Area       Uncert."
""
$SETE #IV1 1
$SETE #IV5 16
$SETE #IV2 RECCNT(PSORIGAREA)
$REC 1 PSENERGY 1 0 #IV2
$REC 2 PSORIGAREA 1 0 #IV2
$REC 3 PSORIGERR 1 0 #IV2
$REC 4 PSAMBBACK 1 0 #IV2
$REC 5 PSDAMBBACK 1 0 #IV2
$REC 6 PSAREA 1 0 #IV2
$REC 7 PSDAREA 1 0 #IV2
$REC 8 PSPPFIT 1 0 #IV2
$REC 9 PSPMULT 1 0 #IV2
$BT #IV2
$IF #REC8(#IV1)
  $IF #REC9(#IV1)
    $SETE #SV1 ' M'
  $ELSE
    $SETE #SV1 'F '
  $ENDIF
$ELSE
  $IF #REC9(#IV1)
    $SETE #SV1 ' m'
  $ELSE
    $SETE #SV1 '  '
  $ENDIF
$ENDIF
$IF PSPENBACK(#IV1,0)
"|A|II |FFFF.FF |EEEEEEEEE |FFF.FF  |EEEEEEEEE |EEEEEEEEE |EEEEEEEEE |EEEEEEEEE" #SV1 #IV1 #REC1(#IV1) #REC2(#IV1) #REC3(#IV1)/EM #REC4(#IV1) #REC5(#IV1)/EM #REC6(#IV1) #REC7(#IV1)/EM
$ELSE
"|A|II |FFFF.FF |EEEEEEEEE |FFF.FF                        |EEEEEEEEE |EEEEEEEEE" #SV1 #IV1 #REC1(#IV1) #REC2(#IV1) #REC3(#IV1)/EM #REC6(#IV1) #REC7(#IV1)/EM
$ENDIF
$SETA #IV1 1
$REM If new page print column headers.
$SETA #IV5 1
$SETE #IV6 #IV5
$SETD #IV6 56
$IF #IV6
$NP
$SETE #IV5 6
""
" Peak  Energy  Original Orig. Area  Ambient    Backgr.  Subtracted  Subtracted"
"   No. (keV)     Area     Uncert.  Background  Uncert.     Area       Uncert."
""
$ENDIF
$ET
""
""
"M = First peak in a multiplet region"
"m = Other peak in a multiplet region"
"F = Fitted singlet"
""
"Errors quoted at |F.FFF sigma" 1.0/EM
$ELSE
"No peak analysis results available to perform background subtract on."
" OR"
"No peaks remain after background subtracted."
$ENDIF
$ELSE
"No background subtract performed on this spectrum."
$ENDIF
$REM
$REM
$REM +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
$REM Template for Peak Results after (RefPeak+Bkg) Area Correction
$REM
""
$SEC NID_Std
$PH "Nuclide Identification Report        |DDDDDDDDD |TTTTTTTTTT        Page |I" #datetime #datetime #pagenum
$REM $NP 57
""
$SEC NID_Intf
$PH "Interference Corrected Activity Report    |DDDDDDDDD |TTTTTTTTTT   Page |I" #datetime #datetime #pagenum
$REM $NP 57
""
$IF NIDFNID
$REM -1---------2---------3---------4---------5---------6---------7---------
"*************************************************************************"
"*****   N U C L I D E   I D E N T I F I C A T I O N   R E P O R T   *****"
"*************************************************************************"
""
$REM "     Sample Title:         |AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" STITLE
$SETE #IV9 PRUSESTRLIB
$IFNOT #IV9
"  Nuclide Library Used: |AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" EXPLIB
$ENDIF
$IF #IV9
"     Nuclide Library Used: Internal Library"
$ENDIF
$SETE #IV11 NIDFCSCDONE
$IF   #IV11  ! CSC was done
""
$REM "     ISOCS Geom. |QQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQ" ISOCSFILE
$ENDIF
""
$SETE #SV3 ACTIVUNITS
$SETE #FV1 ACTIVMULT
$IFNOT #FV1
$SETE #FV1 1.0
$SETE #SV3 'uCi'
$ENDIF
"   ....................    IDENTIFIED NUCLIDES     ...................."
""
$IFNOT #IV11
"   Nuclide    Id       Energy    Yield     Activity     Activity"
"   Name    Confidence  (keV)      (%)     (|AA/|AAA)   Uncertainty" #SV3 SUNITS
$ELSE
"   Nuclide    Id       Energy    Yield     Activity     Activity    Coinc"
"   Name    Confidence  (keV)      (%)     (|AA/|AAA)   Uncertainty  Corr" #SV3 SUNITS
$ENDIF
""
$DEFL NLENERGY NLPEAK NLABUN NLACTVTY NLERR NLCOICF NLCOIAPP NLCOINOTI NIDCOIERR
$SETE #IV1 1
$SETE #IV5 14
$SETE #IV8 RECCNT(NCLNAME)
$SETE #FV2 #FV1
$SETM #FV2 1.0/EM
$REC 1 NCLNAME 1 0 #IV8
$REC 2 NCLCONFID 1 0 #IV8
$REC 3 NCLFIDENT 1 0 #IV8

$REM Added this line for Parent daughter correction
$REC 7 NCLFPDCORRDN 1 0 #IV8

$BT #IV8 ! Begin nuclide loop
 $IF #REC3(#IV1) ! if nuclide identified A
  $SETE #IV2 0
  $SETE #IV4 1
  $SETE #IV9 ENTCNT(NCLLINE,#IV1)
  $TBL 1 NCLLINE #IV1 1 #IV9
  $SETE #IV3 #TBL1(1)

  $BT #IV9 ! Begin line loop
   $GETL 2 #IV3 0
   $SETE #IV7 NLFNOUSEWTM(#IV3,1)
   $SETE #IV12 #LIS2(2)
   $SETA #IV12 #REC7(#IV1)
   $REM --- #IV12 is now the OR of 'this line ID-ed' and 'this nuclide P/D corrected'
   $IFNOT #IV2 ! If this is the first line of the nuclide, print nuclide name and confid as well as line info B
    $IF #IV12 ! ID'd or P/D applied C
     $IFNOT #IV11 ! Coinc. Corr. not done D
      $REM " |A|AAAAAAA |F.FFF  |FFFF.FF|A|A|FF.FF  |EEEEEEEEEEEE |EEEEEEEEEEEE" #REC7(#IV1)/TF=!: #REC1(#IV1)  #REC2(#IV1) #LIS2(1) #LIS2(2)/TF=*: #IV7/TF=@: #LIS2(3) #LIS2(4)/MU=#FV1 #LIS2(5)/MU=#FV2
      "   |AAAAAAA |F.FFF  |FFFF.FF|A|A|FF.FF  |EEEEEEEEEEEE |EEEEEEEEEEEE" #REC1(#IV1)  #REC2(#IV1) #LIS2(1) #LIS2(2)/TF=*: #IV7/TF=@: #LIS2(3) #LIS2(4)/MU=#FV1 #LIS2(5)/MU=#FV2
     $ELSE ! Coinc corr done D
      $REM Check warning/error code
      $IFEQ #LIS2(9) 0  ! E
       $SETE #IV13 0 ! --- then there is no warning or error.
      $ELSE ! some problem; see how bad it is E
       $IFEQ #LIS2(9) 315 ! F
        $SETE #IV13 0 ! -- merely warning that det. characterization does not cover low energies
       $ELSE  ! F
	    $IFEQ #LIS2(9) 537199722 ! some lines did not match
		 $SETE #IV13 0
		$ELSE
         $SETE #IV13 1 ! -- a real problem
		$ENDIF
       $ENDIF ! F
      $ENDIF ! End of Check warning/error code E
      $REM Use results of evaluating code      
      $IFEQ #IV13 1 ! a real problem; print "err" G
        "   |AAAAAAA |F.FFF  |FFFF.FF|A|A|FF.FF  |EEEEEEEEEEEE |EEEEEEEEEEEE err" #REC1(#IV1) #REC2(#IV1) #LIS2(1) #LIS2(2)/TF=*: #IV7/TF=@: #LIS2(3) #LIS2(4)/MU=#FV1 #LIS2(5)/MU=#FV2 
      $ELSE ! no warning or error, but see if missing or COI free G
       $IF #LIS2(7) ! CAM_L_NLCOIAPP = 1 -> COI applied (a valid number) H
        "   |AAAAAAA |F.FFF  |FFFF.FF|A|A|FF.FF  |EEEEEEEEEEEE |EEEEEEEEEEEE|F.FFF" #REC1(#IV1) #REC2(#IV1) #LIS2(1) #LIS2(2)/TF=*: #IV7/TF=@: #LIS2(3) #LIS2(4)/MU=#FV1 #LIS2(5)/MU=#FV2 #LIS2(6)
       $ELSE ! COI not applied; print "miss" or "free" depending on CAM_L_NLCOINOTI H
        "   |AAAAAAA |F.FFF  |FFFF.FF|A|A|FF.FF  |EEEEEEEEEEEE |EEEEEEEEEEEE |AAA" #REC1(#IV1) #REC2(#IV1) #LIS2(1) #LIS2(2)/TF=*: #IV7/TF=@: #LIS2(3) #LIS2(4)/MU=#FV1 #LIS2(5)/MU=#FV2 #LIS2(8)/TF=free:miss
       $ENDIF ! H
      $ENDIF ! G
     $ENDIF ! D
    $ELSE ! not IDd and no P/D; merely print line info C
     "   |AAAAAAA |F.FFF  |FFFF.FF|A|A|FF.FF" #REC1(#IV1) #REC2(#IV1) #LIS2(1) #LIS2(2)/TF=*: #IV7/TF=@: #LIS2(3)
    $ENDIF ! C
   $ELSE ! not the first line of the nuclide; merely print line info B
    $IF #IV12 ! ID'd or P/D applied I
     $IFNOT #IV11 ! Coinc. Corr. not done J
      "                    |FFFF.FF|A|A|FF.FF  |EEEEEEEEEEEE |EEEEEEEEEEEE" #LIS2(1) #LIS2(2)/TF=*: #IV7/TF=@: #LIS2(3) #LIS2(4)/MU=#FV1 #LIS2(5)/MU=#FV2
     $ELSE ! Coinc corr done J
      $REM Check warning/error code
      $IFEQ #LIS2(9) 0 ! K
       $SETE #IV13 0 ! --- then there is no warning or error.
      $ELSE ! some problem; see how bad it is K *** 5/5/11 TLG Added test for 537199722 - some lines did not match ***
       $IFEQ #LIS2(9) 315 ! L
         $SETE #IV13 0 ! -- merely warning that det. characterization does not cover low energies
       $ELSE ! L
         $IFEQ #LIS2(9) 537199722 ! some lines did not match
             $SETE #IV13 0
         $ELSE
            $SETE #IV13 1 ! -- a real problem 
          $ENDIF
       $ENDIF ! L
      $ENDIF ! End of Check warning/error code K
      $REM Use results of evaluating code      
      $IFEQ #IV13 1 ! a real problem; print "err" M
       "                    |FFFF.FF|A|A|FF.FF  |EEEEEEEEEEEE |EEEEEEEEEEEE err" #LIS2(1) #LIS2(2)/TF=*: #IV7/TF=@: #LIS2(3) #LIS2(4)/MU=#FV1 #LIS2(5)/MU=#FV2
      $ELSE ! no warning or error, but see if missing or COI free M
       $IF #LIS2(7) ! CAM_L_NLCOIAPP = 1 -> COI applied (a valid number) N
        "                    |FFFF.FF|A|A|FF.FF  |EEEEEEEEEEEE |EEEEEEEEEEEE|F.FFF" #LIS2(1) #LIS2(2)/TF=*: #IV7/TF=@: #LIS2(3) #LIS2(4)/MU=#FV1 #LIS2(5)/MU=#FV2 #LIS2(6)
       $ELSE ! COI not applied; print "miss" or "free" depending on CAM_L_NLCOINOTI N
        "                    |FFFF.FF|A|A|FF.FF  |EEEEEEEEEEEE |EEEEEEEEEEEE |AAA" #LIS2(1) #LIS2(2)/TF=*: #IV7/TF=@: #LIS2(3) #LIS2(4)/MU=#FV1 #LIS2(5)/MU=#FV2 #LIS2(8)/TF=free:miss
       $ENDIF ! N
      $ENDIF ! M
     $ENDIF ! J
    $ELSE ! not IDd  and no P/D; merely print line info I
     "                    |FFFF.FF|A|A|FF.FF" #LIS2(1) #LIS2(2)/TF=*: #IV7/TF=@: #LIS2(3)
    $ENDIF ! I
   $ENDIF ! B
   $REM Finished printing line; increment counters
   $SETA #IV5 1
   $SETE #IV2 1
   $SETA #IV4 1
   $SETE #IV3 #TBL1(#IV4)
   $REM If new page print column headers.
   $SETE #IV6 #IV5
   $SETD #IV6 56
   $IF #IV6
    $NP
    $SETE #IV5 5
    ""
    $IFNOT #IV11
     "   Nuclide    Id       Energy    Yield    Activity     Activity"
     "   Name    Confidence  (keV)      (%)    (|AA/|AAA)   Uncertainty" #SV3 SUNITS
    $ELSE
     "   Nuclide    Id       Energy    Yield     Activity     Activity    Coinc"
     "   Name    Confidence  (keV)      (%)     (|AA/|AAA)   Uncertainty  Corr" #SV3 SUNITS
    $ENDIF
    ""
    $SETE #IV2 0
   $ENDIF
  $ET ! End line loop
   
 $ENDIF ! End if nuclide identified; processing for 1 nuclide A
 $SETA #IV1 1 ! Increment nuclide counter 
$ET ! End nuclide loop

""
$DEFL TOLERANCE CONFID SIGMA PSDATE PEAKSTART PEAKEND
$GETL 1 1 0
"       * = Energy line found in the spectrum."
"       @ = Energy line not used for Weighted Mean Activity"
$IF NIDFPDCDONE
$REM "       ! = nuclide was corrected for parent/daughter"
$ENDIF

$IF USEVARETOL
$SETE #FV3 VARTOLERANCE
"       Energy Tolerance : |FFF.FFF FWHM" #FV3
$ELSE
$SETE #FV3 TOLERANCE
$SETD #FV3 ECALCNV
"       Energy Tolerance : |FFF.FFF |AA" #FV3 ECALUNITS
$ENDIF
"       Nuclide confidence index threshold = |FF.FF" #LIS1(2)
"       Errors quoted at |F.FFF sigma" 1.0/EM
$IF #IV11
 "       Coincidence correction performed."
 "       free = No coincidence correction required."
 "       miss = Nuclide energy was not found in the coincidence library."
 "       err  = Error in coincidence correction calculation."
 $REM must break up this chain of possible error codes because limited support for nested IFs
 $IFNE NIDCOIERR 0
  "       ISOCS/LabSOCS/Coinc. Corr. Warning/error code = |IIIIIIIIIIIIIII" NIDCOIERR
  $IFEQ NIDCOIERR 12 ! 0x000C
   "       Error getting address of COI(*)"
  $ENDIF
  $IFEQ NIDCOIERR 123 ! 0x007B = error getting nuclide name
   "       Error getting nuclide name"
  $ENDIF
  $IFEQ NIDCOIERR 257 ! 0x0101 = error loading SOCSAccess
   "       Error loading SOCSAccess.DLL"
  $ENDIF 
  $IFEQ NIDCOIERR 258 ! 0x0102 = error getting ExportAppropriateGIS(*) address from SOCSAccess.DLL
   "       Error getting export function address from  SOCSAccess.DLL"
  $ENDIF
  $IFEQ NIDCOIERR 259 ! 0x0103 = error getting LoadGeoC(*)( address from SOCSAccess.DLL
   "       Error getting load GEO data function address from  SOCSAccess.DLL"
  $ENDIF 
  $IFEQ NIDCOIERR 260 ! 0x0104 = error creating GIS file
        "       Error creating GIS file"
  $ENDIF
  $IFEQ NIDCOIERR 261 ! 0x0105 = error creating GIS file
   "       Error loading data from GEO file"
  $ENDIF
  $IFEQ NIDCOIERR 315 ! 0x013B = old school det char
   "       Detector characterization calibration prevents use of"
   "           low energy gamma rays and X-rays in Coincidence Correction."
  $ENDIF
  $IFEQ NIDCOIERR 537199608 ! 0x200503F8 = error reading GEO file name
   "       COIERR_PARAMHASNOVALUE Error reading Geometry File Name"
  $ENDIF 
  $IFEQ NIDCOIERR 537199722 ! 0x2005046A - some lines did not match
   "          COIERR_NOSETINVOLVEDLINES (Warning: for one or more nuclides,"
   "                                 no lines matched the COI library set)"
  $ENDIF 
  $IFEQ NIDCOIERR 537199755  ! 0x2005048B = COIERR_IDENTARRAYSAREFULL
   "  *** COIERR_IDENTARRAYSAREFULL (Arrays for Coinc. Corr. have been ***"
   "  *** overwritten. Data are suspect.                               ***"
  $ENDIF 
  $IFEQ NIDCOIERR 537199805  ! 0x200504BD 
   "  COIERR_CAMPTCCLOAD  Error loading Peak-to-Total Calibration"
  $ENDIF
  $IFEQ NIDCOIERR 537199832 ! 0x200504D8 = Can't open GIS file
   "        COIERR_ISOCSFILEOPEN = ISOCS Can't open GIS file."
   "        File may be missing, locked, etc."
  $ENDIF ! Error = 537199832 ... ELSE
  $IFEQ NIDCOIERR 537199883 ! 0x2005050B = Internal ISOCS error (bad geo file)
   "        COIERR_INTERNALISOCSERROR = Internal ISOCS error."
   "        May be an invalid geometry or corrupt file."
  $ENDIF  ! Error = 537199883 ... ELSE 	
  $IFEQ NIDCOIERR -337084230 ! 0xEBE880B2
   "        CAM__NOFREPBE = Cannot create block - no free pointer block entries."
  $ENDIF
  $IFEQ NIDCOIERR 537199884 ! 0x2005050C
   "        COIERR_CALLCOIDLL = Error loading Cascade Summing DLL."
  $ENDIF
 $ENDIF    ! != 0 
$ENDIF  ! #IV11
""
$ENDIF
$IF NIDFINTERF
$NP
""
"*************************************************************************"
"*****   I N T E R F E R E N C E   C O R R E C T E D   R E P O R T   *****"
$IF NIDFPDCDONE
"****  W i t h   P A R E N T / D A U G H T E R   C O R R E C T I O N  ****"
$ENDIF
"*************************************************************************"
""
""
"                 Nuclide       Wt mean         Wt mean"
"       Nuclide     Id          Activity        Activity"
"       Name     Confidence    (|AA/|AAA)      Uncertainty" #SV3 SUNITS
""
$SETE #IV1 1
$SETE #IV5 13
$SETE #IV9 RECCNT(NCLNAME)
$REC 1 NCLNAME 1 0 #IV9
$REC 2 NCLCONFID 1 0 #IV9
$REC 3 NCLWTMEAN 1 0 #IV9
$REC 4 NCLWTMERR 1 0 #IV9
$REC 5 NCLFINTFREJ 1 0 #IV9
$REC 6 NCLFIDENT 1 0 #IV9
$REC 7 NCLFPDCORRDN 1 0 #IV9
$BT #IV9
$SETE #IV7 0
$SETE #IV4 ENTCNT(NCLLINE,#IV1)
$TBL 1 NCLLINE #IV1 1 #IV4
$SETE #IV10 #REC6(#IV1)
$SETA #IV10 #REC5(#IV1)
$SETE #IV2 1
$BT #IV4
$SETE #IV3 #TBL1(#IV2)
$SETA #IV7 NLFNOUSEWTM(#IV3,1)
$SETA #IV2 1
$ET
$IF #IV10
$IFNOT #REC5(#IV1)
$REM "Don't report zero activities"
"  |A|A |AAAAAAA|A|F.FFF     |EEEEEEEEEEEEE  |EEEEEEEEEEEEE" #REC7(#IV1)/TF=!: NCLFUNRESINT(#IV1,0)/TF=?: #REC1(#IV1) #IV7/TF=@: #REC2(#IV1) #REC3(#IV1)/MU=#FV1 #REC4(#IV1)/MU=#FV2
$ELSE
"  |AX  |AAAAAAA  |F.FFF" #REC7(#IV1)/TF=!: #REC1(#IV1) #REC2(#IV1)
$ENDIF
$SETA #IV5 1
$ENDIF
$SETA #IV1 1
$REM If new page print column headers.
$SETE #IV6 #IV5
$SETD #IV6 56
$IF #IV6
$NP
$SETE #IV5 6
""
"                 Nuclide       Wt mean         Wt mean"
"       Nuclide     Id          Activity        Activity"
"       Name     Confidence    (|AA/|AAA)      Uncertainty" #SV3 SUNITS
""
$ENDIF
$ET
""
$IF NIDFPDCDONE
"       ! = nuclide was corrected for parent/daughter"
$ENDIF
"       ? = nuclide is part of an undetermined solution"
"       X = nuclide rejected by the interference analysis"
"       @ = nuclide contains energy lines not used in Weighted Mean Activity"
""
"       Errors quoted at |F.FFF sigma" 1.0/EM
""
$ENDIF
$IF NIDFNID
$IFNOT NIDFINTERF
"No interference correction results available for reporting purposes."
$ENDIF
$ENDIF
$REM
$IF NIDFNID
$IF RECCNT(PSCENTRD)
$REM Determine if new page should be started for unidentified peaks.
$SETE #IV1 1
$SETE #IV2 0
$BT RECCNT(PSORIGAREA)
$IFNOT PSPKNOWN(#IV1,0)
$SETA #IV2 1
$ENDIF
$ET
$SETE #IV6 #IV5
$SETA #IV6 #IV2
$SETA #IV6 22
$SETD #IV6 56
$IF #IV6
$NP
$SETE #IV5 10
$ENDIF
$REM End check page.
""
"   **********   U N I D E N T I F I E D   P E A K S   **********"
""
"               Peak Locate Performed on:  |DDDDDDDDD |TTTTTTTTTT" #LIS1(4) #LIS1(4)
"               Peak Locate From Channel:  |IIII" #LIS1(5)
"               Peak Locate To Channel:    |IIII" #LIS1(6)
""
"       Peak   Energy     Peak Size in        Peak CPS      Peak     Tol."
"        No.   (keV)    Counts per Second   % Uncertainty   Type   Nuclide"
""
$SETE #IV1 1
$SETE #IV7 0
$BT RECCNT(PSORIGAREA)
$GETR #PM #IV1
$IF #PM15
  $IF #PM17
    $SETE #SV2 ' M'
  $ELSE
    $SETE #SV2 'F '
  $ENDIF
$ELSE
  $IF #PM17
    $SETE #SV2 ' m'
  $ELSE
    $SETE #SV2 '  '
  $ENDIF
$ENDIF
$IF #PM16
$IFNOT PSPKNOWN(#IV1,0)
$REM                        Enhanced Tentative NID
$SETE #IV8 #IV1
$REM $SETS #IV8 1
$IFEQ PMPEAKORIGIN(#IV8,1) 0
$SETE #SV3 '        '
$ENDIF
$IFEQ PMPEAKORIGIN(#IV8,1) 1
$SETE #SV3 ' S-Esc. '
$ENDIF
$IFEQ PMPEAKORIGIN(#IV8,1) 2
$SETE #SV3 ' D-Esc. '
$ENDIF
$IFEQ PMPEAKORIGIN(#IV8,1) 3
$SETE #SV3 ' Sum    '
$ENDIF
$IFEQ PMPEAKORIGIN(#IV8,1) 4
$SETE #SV3 ' Tol.   '
$ENDIF

$REM
$SETA #IV7 1

$REM 7 aug 2006 jjl Change PMNCLNAME to PMNCLNAMET
$SETE #IV9 ENTCNT(PMNCLNAMET,#IV1)
$REM 3 Jan 2007 jjl Change test from $IFGT to $IFGE
$IFGE #IV9 1
	$REM set to 1 less to cover blank entry at end
	$REM 3 Jan 2007 JJL remove because now no blanks $SETS #IV9 1
	$REM #IV4 - entry counter
	$SETE #IV4 1
	$SETE #IV8 1
	$BT #IV9
        $REM 7 aug 2006 jjl Change PMNCLNAME to PMNCLNAMET
		$SETE #SV4 PMNCLNAMET(#IV1,#IV4)
		$IFEQ #IV4 1
			"     |A|II |FFFF.FF      |EEEEEEEEEEE        |FFF.FF      |AAAAAAAA  |AAAAAAA" #SV2 #IV1 #PM1 #PM11 #PM12/EM #SV3 #SV4
			$SETA #IV5 1
		$ENDIF
		$IFGT #IV4 1
			$IF #IV8
                $REM 7 aug 2006 jjl Change PMNCLNAME to PMNCLNAMET
				$SETE #SV4 PMNCLNAMET(#IV1,#IV4)
				"     |A|II |FFFF.FF                                                  |AAAAAAA "  #SV2 #IV1 #PM1 #SV4
				$SETA #IV5 1
			$ELSE
                		$REM 7 aug 2006 jjl Change PMNCLNAME to PMNCLNAMET
				$REM Only print if string is not blank

                		$IFEQSI #SV4 ''
                		$ELSE
				    "                                                                     |AAAAAAA "  #SV4
				    $SETA #IV5 1
                		$ENDIF
			$ENDIF
		$ENDIF
$REM
$REM
$REM			#IV1 - Peak Number
$REM			#IV8 - Peak Number -1
$REM            7 aug 2006 jjl Change PMNCLNAME to PMNCLNAMET
$REM			#IV9 - Count of PMNCLNAMET
$REM
$REM
$REM 
$REM
$REM		$SETA #IV5 1

		$REM If new page print column headers.
		$SETE #IV6 #IV5
		$SETD #IV6 56
		$IF #IV6
			$NP
			$SETE #IV5 6
			""
			"       Peak   Energy     Peak Size in        Peak CPS      Peak     Tol."
			"        No.   (keV)    Counts per Second   % Uncertainty   Type   Nuclide"
			$SETE #IV8 1
		$ELSE
			$SETE #IV8 0
		$ENDIF
		$REM Increment entry counter
		$SETA #IV4 1

	$ET

$ELSE
	$REM Tabular entries = 1 - no tolerance nuclide names
	"     |A|II |FFFF.FF      |EEEEEEEEEEE        |FFF.FF      |AAAAAAAA" #SV2 #IV1 #PM1 #PM11 #PM12/EM #SV3
	$SETA #IV5 1
$ENDIF
$REM 
$ENDIF
$ENDIF
$SETA #IV1 1
$REM If new page print column headers.
$SETE #IV6 #IV5
$SETD #IV6 56
$IF #IV6
$NP
$SETE #IV5 5
""
"       Peak   Energy     Peak Size in        Peak CPS      Peak     Tol."
"        No.   (keV)    Counts per Second   % Uncertainty   Type   Nuclide"
""
$ENDIF
$ET
$IF #IV7


""
"       M = First peak in a multiplet region"
"       m = Other peak in a multiplet region"
"       F = Fitted singlet"
""
"       Errors quoted at |F.FFF sigma" 1.0/EM
$ELSE
"       All peaks were identified."
$ENDIF
$ELSE
"No peak search results available for nuclide analysis."
$ENDIF
$ELSE

"No nuclide identification results available for reporting purposes"
$ENDIF
$REM
$REM ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
$REM Nuclide MDA Template

$REM
""
$SEC MDADECLVL
$PH "Nuclide MDA Report                      |DDDDDDDDD |TTTTTTTTTT     Page |I" #datetime #datetime #pagenum
$REM $NP 57
""
$IF NIDFMDA
$REM ----1---------2---------3---------4---------5---------6---------7---------8
"**************************************************************************"
"*****              N U C L I D E   M D A   R E P O R T               *****"
"**************************************************************************"
""
$DEFL DETNAME SGEOMTRY STITLE EXPLIB
$GETL 1 1 0
$REM "     Detector Name:        |AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" #LIS1(1)
$REM "     Sample Geometry:      |AAAAAAAAAAAAAAA" #LIS1(2)
$REM "     Sample Title:         |AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" #LIS1(3)
$SETE #IV9 PRUSESTRLIB
$IFNOT #IV9
"     Nuclide Library Used: |AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" #LIS1(4)
$ENDIF
$IF #IV9
"     Nuclide Library Used: Internal Library"
$ENDIF
""
$SETE #SV3 ACTIVUNITS
$SETE #FV1 ACTIVMULT
$IFNOT #FV1
$SETE #FV1 1.0
$SETE #SV3 'uCi'
$ENDIF
""
"        Nuclide   Energy    Yield    Line MDA  Nuclide MDA  Activity   Dec. Level"
"        Name      (keV)      (%)    (|AA/|AAA) (|AA/|AAA)  (|AA/|AAA)  (|AA/|AAA)" #SV3 SUNITS #SV3 SUNITS #SV3 SUNITS #SV3 SUNITS
""
$DEFL NLMDA NLENERGY NLPEAK NLABUN NLACTVTY NLDETLIMIT NLMDADECLVL
$SETE #IV1 1
$SETE #IV5 14
$SETE #IV9 RECCNT(NCLNAME)
$REC 1 NCLNAME 1 0 #IV9
$REC 2 NCLFIDENT 1 0 #IV9
$REC 3 NCLFSHORTHL 1 0 #IV9
$REC 4 NCLFNORPTMDA 1 0 #IV9
$REC 5 NCLMDA 1 0 #IV9
$REM Added this line for Parent daughter correction
$REC 7 NCLFPDCORRDN 1 0 #IV9

$BT #IV9
$IFNOT #REC4(#IV1)
$SETE #IV2 0
$SETE #IV4 1
$SETE #IV8 ENTCNT(NCLLINE,#IV1)
$TBL 1 NCLLINE #IV1 1 #IV8
$SETE #IV3 #TBL1(1)
$BT #IV8
$GETL 2 #IV3 0
$SETE #FV2 #LIS2(1)
$IFNOT #REC3(#IV1)
$SETD #FV2 #LIS2(6)
$SETM #FV2 #FV1
$SETM #FV2 #LIS2(7)
$ENDIF
$IFNOT #IV2
"|A|A|A|A|AAAAAAA |FFFF.FF|A |FF.FF |EEEEEEEEEE |EEEEEEEEE |EEEEEEEEEE |EEEEEEEEEE"  #REC7(#IV1)/TF=!: #REC2(#IV1)/TF=+: #LIS2(1)/TF=:> #REC3(#IV1)/TF=@: #REC1(#IV1) #LIS2(2) #LIS2(3)/TF=*: #LIS2(4) #LIS2(1)/MU=#FV1 #REC5(#IV1)/MU=#FV1 #LIS2(5)/MU=#FV1 #FV2
$SETE #IV2 1
$ELSE
$REM Not first line.
"    |A|A         |FFFF.FF|A |FF.FF |EEEEEEEEEE            |EEEEEEEEEE |EEEEEEEEEE" #LIS2(1)/TF=:> #REC3(#IV1)/TF=@: #LIS2(2) #LIS2(3)/TF=*: #LIS2(4) #LIS2(1)/MU=#FV1 #LIS2(5)/MU=#FV1 #FV2
$ENDIF
$SETA #IV4 1
$SETE #IV3 #TBL1(#IV4)
$REM If new page print column headers.
$SETA #IV5 1
$SETE #IV6 #IV5
$SETD #IV6 56
$IF #IV6
$NP
$SETE #IV5 5
""
"        Nuclide   Energy    Yield    Line MDA  Nuclide MDA  Activity   Dec. Level"
"        Name      (keV)      (%)    (|AA/|AAA) (|AA/|AAA)  (|AA/|AAA)  (|AA/|AAA)" #SV3 SUNITS #SV3 SUNITS #SV3 SUNITS #SV3 SUNITS
""
$SETE #IV2 0
$ENDIF
$ET
$ENDIF
$SETA #IV1 1
$ET
""
"       + = Nuclide identified during the nuclide identification"
"       * = Energy line found in the spectrum"
"       > = Calculated MDA is zero due to zero counts in the region, or "
"           the region is outside the spectrum, or MDA has not been calculated"
"       @ = Half-life too short to be able to perform the decay correction"
$IF NIDFPDCDONE
"       ! = nuclide was corrected for parent/daughter"
$ENDIF
$ENDIF
$IFNOT NIDFMDA
"No MDA analysis results available for reporting purposes"
$ENDIF


$REM
$REM ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
$REM ISO11929 MDA Template

$REM