PGDMP     ;                    z            dburun    14.2    14.2                0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false                       0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false                       0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false                       1262    16400    dburun    DATABASE     c   CREATE DATABASE dburun WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'Turkish_Turkey.1252';
    DROP DATABASE dburun;
                postgres    false            ?            1259    16423    books    TABLE     ?   CREATE TABLE public.books (
    id integer NOT NULL,
    title character varying,
    "genreıd" integer NOT NULL,
    pagecount integer NOT NULL,
    publishdate date NOT NULL
);
    DROP TABLE public.books;
       public         heap    postgres    false            ?            1259    16430    books_id_seq    SEQUENCE     ?   ALTER TABLE public.books ALTER COLUMN id ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public.books_id_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1
);
            public          postgres    false    212            ?            1259    16413    kategori    TABLE     G   CREATE TABLE public.kategori (
    id integer NOT NULL,
    ad text
);
    DROP TABLE public.kategori;
       public         heap    postgres    false            ?            1259    16401    musteri    TABLE     ?   CREATE TABLE public.musteri (
    "ıd" integer NOT NULL,
    ad character varying(15) NOT NULL,
    soyad character varying(14) NOT NULL,
    sehir text
);
    DROP TABLE public.musteri;
       public         heap    postgres    false            ?            1259    16408    urun    TABLE     ?   CREATE TABLE public.urun (
    "ıd" integer NOT NULL,
    ad character varying(15),
    turu character varying(20),
    stok integer
);
    DROP TABLE public.urun;
       public         heap    postgres    false            ?          0    16423    books 
   TABLE DATA           N   COPY public.books (id, title, "genreıd", pagecount, publishdate) FROM stdin;
    public          postgres    false    212   ?       ?          0    16413    kategori 
   TABLE DATA           *   COPY public.kategori (id, ad) FROM stdin;
    public          postgres    false    211   I       ?          0    16401    musteri 
   TABLE DATA           :   COPY public.musteri ("ıd", ad, soyad, sehir) FROM stdin;
    public          postgres    false    209   f       ?          0    16408    urun 
   TABLE DATA           5   COPY public.urun ("ıd", ad, turu, stok) FROM stdin;
    public          postgres    false    210   N                  0    0    books_id_seq    SEQUENCE SET     ;   SELECT pg_catalog.setval('public.books_id_seq', 14, true);
          public          postgres    false    213            o           2606    16429    books books_pkey 
   CONSTRAINT     e   ALTER TABLE ONLY public.books
    ADD CONSTRAINT books_pkey PRIMARY KEY (id, "genreıd", pagecount);
 :   ALTER TABLE ONLY public.books DROP CONSTRAINT books_pkey;
       public            postgres    false    212    212    212            m           2606    16419    kategori kategori_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.kategori
    ADD CONSTRAINT kategori_pkey PRIMARY KEY (id);
 @   ALTER TABLE ONLY public.kategori DROP CONSTRAINT kategori_pkey;
       public            postgres    false    211            i           2606    16407    musteri musteri_pkey 
   CONSTRAINT     U   ALTER TABLE ONLY public.musteri
    ADD CONSTRAINT musteri_pkey PRIMARY KEY ("ıd");
 >   ALTER TABLE ONLY public.musteri DROP CONSTRAINT musteri_pkey;
       public            postgres    false    209            k           2606    16412    urun urun_pkey 
   CONSTRAINT     O   ALTER TABLE ONLY public.urun
    ADD CONSTRAINT urun_pkey PRIMARY KEY ("ıd");
 8   ALTER TABLE ONLY public.urun DROP CONSTRAINT urun_pkey;
       public            postgres    false    210            ?   ?   x?e?;?0D?ٻy?v@q#,9?ȧ?[q??ʆv????"?? `c!J?Q?a??1???G??t?䟟?j3J?l?Pe?
?2???:g???i???h?|V14W?5??-w??Kl??t??~?-]6D?R7      ?      x?????? ? ?      ?   ?   x??=N?@??7?A	$??F?(?EAi?xd?v=Fkɾ ??%-??y}/?????{kd]?U%9?oV&?ߦe}?]??Y?4a?ǳ3T????$6?0?u??O?|R?$&?&R?????Ef|?m??ary??_?l-;?k?ً?At???
n?????w??㾋?ErVw?f@?X??R?AwH?????Zs????O??*.??x???E????*t? ??ScZ?      ?   f   x???1
?0 ?9}E^ V}?up???6`AR??~_???&??q ?#?'??11?Zi??1??$??31?8J????La¯܁qW????ֿd??R?2?     