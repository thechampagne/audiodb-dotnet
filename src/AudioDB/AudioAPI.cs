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
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace AudioDB
{
    /// <summary>
    /// TheAudioDB API client
    /// <br/>
    /// TheAudioDB is a community Database of
    /// audio artwork and metadata
    /// </summary>
    public class AudioAPI
    {
        private static string Http(string endpoint)
        {
            try
            {
                HttpWebRequest client = (HttpWebRequest) WebRequest.Create($"https://theaudiodb.com/api/v1/json/2/{endpoint}");
                client.Method = "GET";
                var webResponse = client.GetResponse();
                var webStream = webResponse.GetResponseStream();
                var responseReader = new StreamReader(webStream);
                var response = responseReader.ReadToEnd();
                responseReader.Close();
                responseReader.Dispose();
                return response;
            }
            catch (Exception)
            {
                return null;
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <returns>Artist details from artist name</returns>
        public static Artist SearchArtist(string s)
        {
            try
            {
                var response = Http($"search.php?s={Uri.EscapeDataString(s)}");
                if (response != null && response.Length != 0)
                {
                    BaseArtist data = JsonConvert.DeserializeObject<BaseArtist>(response);
                    if (data.artists != null && data.artists.Count != 0)
                    {
                        return data.artists[0];
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <returns>Discography for an Artist with Album names and year only</returns>
        public static List<Discography> Discography(string s)
        {
            try
            {
                var response = Http($"discography.php?s={Uri.EscapeDataString(s)}");
                if (response != null && response.Length != 0)
                {
                    BaseDiscography data = JsonConvert.DeserializeObject<BaseDiscography>(response);
                    if (data.album != null && data.album.Count != 0)
                    {
                        List<Discography> list = new List<Discography>();
                        foreach (var i in data.album)
                        {
                            list.Add(i);
                        }
                        if (list.Count == 0)
                        {
                            return null;
                        }
                        else
                        {
                            return list;
                        }
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="l"></param>
        /// <returns>individual Artist details using known Artist ID</returns>
        public static Artist SearchArtistById(long l)
        {
            try
            {
                var response = Http($"artist.php?i={l}");
                if (response != null && response.Length != 0)
                {
                    BaseArtist data = JsonConvert.DeserializeObject<BaseArtist>(response);
                    if (data.artists != null && data.artists.Count != 0)
                    {
                        return data.artists[0];
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="l"></param>
        /// <returns>individual Album info using known Album ID</returns>
        public static Album SearchAlbumById(long l)
        {
            try
            {
                var response = Http($"album.php?m={l}");
                if (response != null && response.Length != 0)
                {
                    BaseAlbum data = JsonConvert.DeserializeObject<BaseAlbum>(response);
                    if (data.album != null && data.album.Count != 0)
                    {
                        return data.album[0];
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="l"></param>
        /// <returns>All Albums for an Artist using known Artist ID</returns>
        public static List<Album> SearchAlbumsByArtistId(long l)
        {
            try
            {
                var response = Http($"album.php?i={l}");
                if (response != null && response.Length != 0)
                {
                    BaseAlbum data = JsonConvert.DeserializeObject<BaseAlbum>(response);
                    if (data.album != null && data.album.Count != 0)
                    {
                        List<Album> list = new List<Album>();
                        foreach (var i in data.album)
                        {
                            list.Add(i);
                        }
                        if (list.Count == 0)
                        {
                            return null;
                        }
                        else
                        {
                            return list;
                        }
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="l"></param>
        /// <returns>All Tracks for Album from known Album ID</returns>
        public static List<Track> SearchTracksByAlbumId(long l)
        {
            try
            {
                var response = Http($"track.php?m={l}");
                if (response != null && response.Length != 0)
                {
                    BaseTrack data = JsonConvert.DeserializeObject<BaseTrack>(response);
                    if (data.track != null && data.track.Count != 0)
                    {
                        List<Track> list = new List<Track>();
                        foreach (var i in data.track)
                        {
                            list.Add(i);
                        }
                        if (list.Count == 0)
                        {
                            return null;
                        }
                        else
                        {
                            return list;
                        }
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="l"></param>
        /// <returns>individual track info using a known Track ID</returns>
        public static Track SearchTrackById(long l)
        {
            try
            {
                var response = Http($"track.php?h={l}");
                if (response != null && response.Length != 0)
                {
                    BaseTrack data = JsonConvert.DeserializeObject<BaseTrack>(response);
                    if (data.track != null && data.track.Count != 0)
                    {
                        return data.track[0];
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="l"></param>
        /// <returns>all the Music videos for a known Artist ID</returns>
        public static List<MusicVideo> SearchMusicVideosByArtistId(long l)
        {
            try
            {
                var response = Http($"mvid.php?i={l}");
                if (response != null && response.Length != 0)
                {
                    BaseMusicVideo data = JsonConvert.DeserializeObject<BaseMusicVideo>(response);
                    if (data.mvids != null && data.mvids.Count != 0)
                    {
                        List<MusicVideo> list = new List<MusicVideo>();
                        foreach (var i in data.mvids)
                        {
                            list.Add(i);
                        }
                        if (list.Count == 0)
                        {
                            return null;
                        }
                        else
                        {
                            return list;
                        }
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}