create or replace NONEDITIONABLE PACKAGE SYS_INTERVIEW IS
   --OBJETIVO:Obtener la información de las cuentas
   --HISTORIA:
   --H0: Gabriel López Creación 
   --
  PROCEDURE GETINFOCUENTA (
  pCuentaInfo OUT SYS_REFCURSOR);

END SYS_INTERVIEW;