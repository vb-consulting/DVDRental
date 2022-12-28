CREATE FUNCTION public._group_concat(
    text,
    text
)
RETURNS text
LANGUAGE sql IMMUTABLE
AS $_$
SELECT CASE
  WHEN $2 IS NULL THEN $1
  WHEN $1 IS NULL THEN $2
  ELSE $1 || ', ' || $2
END
$_$;
