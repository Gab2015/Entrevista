create or replace NONEDITIONABLE PROCEDURE     OBTENERINFOCUENTA (
   pCuentaInfo   OUT  SYS_REFCURSOR-- Datos cuenta
) IS
   --OBJETIVO:Obtener la información de las cuentas
   --HISTORIA:
   --H0: Gabriel López Creación 
   --
   vSql              LONG;
   vErrException     EXCEPTION;
BEGIN
   BEGIN
	 --Obtiene la informacion de la cuenta
	 vSql := 'SELECT
	            C.ID,C.NUMERO,C.DESCRIPCION	  
	          FROM
	            SYS.CUENTA C';
   OPEN pCuentaInfo FOR vSql;
   EXCEPTION
      WHEN NO_DATA_FOUND THEN
         NULL;
   END;
EXCEPTION
   WHEN vErrException THEN
      NULL;
   WHEN OTHERS THEN
      NULL;
END OBTENERINFOCUENTA;