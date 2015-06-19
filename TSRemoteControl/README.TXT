Els grups serien els seguents:

RDS_ESP                              RDS01; RDS02; RDS03; RDS04; RDS05; RDS06
RDS_EXT                              RDSEXT
RDS_ADMIN                      RDSADMIN
RDS_POR                            RDSPOR01; RDSPOR02
RDS_POR_EXT                   RDSEXTPOR
RDS_POR_ADMIN           RDSPORADMIN
RDSCAN                              RDSCAN01

Els comandos han de ser:

Saber els usuaris :                          qwinsta /server:rdsCAN01  
Connectar als usuaris:                  mstsc /v:rdsCAN01 /shadow:nºid /control /noconsentprompt
