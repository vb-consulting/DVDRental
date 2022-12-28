CREATE TABLE public.city (
    city_id integer DEFAULT nextval('public.city_city_id_seq'::regclass) NOT NULL PRIMARY KEY,
    city character varying(50) NOT NULL,
    country_id smallint NOT NULL,
    last_update timestamp without time zone DEFAULT now() NOT NULL,
    CONSTRAINT fk_city FOREIGN KEY (country_id) REFERENCES public.country(country_id)
);

CREATE INDEX idx_fk_country_id ON public.city USING btree (country_id);
CREATE TRIGGER last_updated BEFORE UPDATE ON public.city FOR EACH ROW EXECUTE FUNCTION public.last_updated();
