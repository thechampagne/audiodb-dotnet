/*
 * Copyright 2022 XXIV
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using System.Collections.Generic;

namespace AudioDB
{
    public class Artist
    {
        public string idArtist;
        public string strArtist;
        public string strArtistStripped;
        public string strArtistAlternate;
        public string strLabel;
        public string idLabel;
        public string intFormedYear;
        public string intBornYear;
        public string intDiedYear;
        public string strDisbanded;
        public string strStyle;
        public string strGenre;
        public string strMood;
        public string strWebsite;
        public string strFacebook;
        public string strTwitter;
        public string strBiographyEN;
        public string strBiographyDE;
        public string strBiographyFR;
        public string strBiographyCN;
        public string strBiographyIT;
        public string strBiographyJP;
        public string strBiographyRU;
        public string strBiographyES;
        public string strBiographyPT;
        public string strBiographySE;
        public string strBiographyNL;
        public string strBiographyHU;
        public string strBiographyNO;
        public string strBiographyIL;
        public string strBiographyPL;
        public string strGender;
        public string intMembers;
        public string strCountry;
        public string strCountryCode;
        public string strArtistThumb;
        public string strArtistLogo;
        public string strArtistCutout;
        public string strArtistClearart;
        public string strArtistWideThumb;
        public string strArtistFanart;
        public string strArtistFanart2;
        public string strArtistFanart3;
        public string strArtistFanart4;
        public string strArtistBanner;
        public string strMusicBrainzID;
        public string strISNIcode;
        public string strLastFMChart;
        public string intCharted;
        public string strLocked;
    }

    class BaseArtist
    {
        public List<Artist> artists;
    }
}